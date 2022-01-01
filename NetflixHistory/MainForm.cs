using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixHistory {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private static string previousShows;
        private static string previousMovies;
        private static string previousAll;


        private class Filename {
            public const string shows = "SHOWS.txt";
            public const string movies = "MOVIES.txt";
            public const string errors = "ERRORS.txt";
            public const string forbidden = "FORBIDDEN.txt";
            public const string notFound = "NOTFOUND.txt";
        }

        private async void BtnLoadNetflixHistory_Click(object sender, EventArgs e) {

            var progress = new Progress<string>(text => {
                TbProgress.Text = text;
            });

            JArray history = ParseWatchHistoryFiles();

            DGVTVShows.DataSource = CreateTable(history, true);
            DGVMovies.DataSource = CreateTable(history, true);
            DGVError.DataSource = CreateTable(history, true);
            DGVNotFound.DataSource = CreateTable(history, true);
            DGVForbidden.DataSource = CreateTable(history, true);

            await Task.Run(() => LoadNetFlixRatings(history, progress));


        }

        private JArray ParseWatchHistoryFiles() {

            previousShows = File.ReadAllText(Filename.shows);
            previousMovies = File.ReadAllText(Filename.movies);
            previousAll = previousShows + Environment.NewLine + 
                          previousMovies + Environment.NewLine + 
                          File.ReadAllText(Filename.errors) + Environment.NewLine +
                          File.ReadAllText(Filename.forbidden) + Environment.NewLine +
                          File.ReadAllText(Filename.notFound) + Environment.NewLine;

            string[] filenames = Directory.GetFiles("WatchHistory");
            JArray history = new JArray();
            foreach (string filename in filenames) {
                try {
                    string content = File.ReadAllText(filename);
                    JObject ratings = JObject.Parse(content);
                    var ratingItems = ratings["ratingItems"].ToArray();
                    var likes = ratingItems.Where(s => s["yourRating"].ToString() == "2");
                    history.Add(likes);

                } catch (Exception ex) {
                    TbLogs.AppendText($"ParseWatchHistoryFiles: Failed to parse {filename}. Ex: {ex}" + Environment.NewLine);
                }
            }
            return history;
        }

        internal static DataTable CreateTable(JArray jarray, bool onlyCreateColumnNames = false) {
            string response = jarray.ToString();
            DataTable table = new();

            using (var dt = JsonConvert.DeserializeObject<DataTable>(response)) {
                foreach (DataColumn column in dt.Columns) {
                    table.Columns.Add(column.ColumnName);
                }
                table.Columns.Add("TYPE");
                table.Columns.Add("ISNEW");
                table.Columns.Add("NO");

                if (!onlyCreateColumnNames) {
                    foreach (DataRow row in dt.Rows) {
                        table.Rows.Add(row.ItemArray);
                    }
                }
            }

            return table;
        }

        private enum NetflixType { SHOW, MOVIE, UNKOWN, NOTFOUND, FORBIDDEN };
        private NetflixType DetermineType(JObject entity, out bool isNew) {

            string title = entity["title"].ToString();
            isNew = !previousAll.Contains(title);

            if (previousMovies.Contains(title)) return NetflixType.MOVIE;
            if (previousShows.Contains(title)) return NetflixType.SHOW;

            string html = string.Empty;
            string url = @"https://www.netflix.com/se-en/title/" + entity["movieID"].ToString();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            try {
                using HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using Stream stream = response.GetResponseStream();
                using StreamReader reader = new(stream);
                html = reader.ReadToEnd();

            } catch (WebException wex) {

                if (wex.Status == WebExceptionStatus.ProtocolError) {
                    HttpStatusCode status = ((HttpWebResponse)wex.Response).StatusCode;
                    if (status == HttpStatusCode.NotFound) {
                        return NetflixType.NOTFOUND;
                    } else if (status == HttpStatusCode.Forbidden) {
                        return NetflixType.NOTFOUND;
                    }
                }
                Log($"DetermineType: Failed to get data for movie {entity["title"]} (URL: {url}). Ex: {wex}");
                return NetflixType.UNKOWN;

            } catch (Exception ex) {
                Log($"DetermineType: Failed to get data for movie {entity["title"]} (URL: {url}). Ex: {ex}");
                return NetflixType.UNKOWN;
            }

            return html.Contains("\"type\":\"show\"") ? NetflixType.SHOW : NetflixType.MOVIE;
        }

        private void LoadNetFlixRatings(JArray history, IProgress<string> progress) {

            JArray shows = new();
            JArray movies = new();
            JArray errors = new();
            JArray notFound = new();
            JArray forbidden = new();

            foreach (JObject entity in history) {
                NetflixType type = DetermineType(entity, out bool isNew);
                entity["TYPE"] = type.ToString();
                entity["ISNEW"] = isNew.ToString();

                if (type == NetflixType.SHOW) {
                    AddEntity(shows, entity, DGVTVShows);

                } else if (type == NetflixType.MOVIE) {
                    AddEntity(movies, entity, DGVMovies);

                } else if (type == NetflixType.NOTFOUND) {
                    AddEntity(notFound, entity, DGVNotFound);

                } else if (type == NetflixType.FORBIDDEN) {
                    AddEntity(forbidden, entity, DGVForbidden);

                } else {
                    AddEntity(errors, entity, DGVError);
                }

                if (progress != null) {
                    progress.Report((shows.Count + movies.Count + errors.Count + 
                        forbidden.Count + notFound.Count) + "/" + history.Count);
                }
            }

            WriteToFileAsync(Filename.shows, shows);
            WriteToFileAsync(Filename.movies, movies);
            WriteToFileAsync(Filename.errors, errors);
            WriteToFileAsync(Filename.forbidden, forbidden);
            WriteToFileAsync(Filename.notFound, notFound);
        }

        private static void AddEntity(JArray list, JObject entity, DataGridView dgv) {
            entity["NO"] = list.Count + 1;
            list.Add(entity);

            DataTable table = (DataTable)dgv.DataSource;
            DataRow newRow = table.NewRow();
            newRow.ItemArray = entity.Properties().Select(p => p.Value).ToArray();
            table.Rows.Add(newRow);
        }

        public static void WriteToFileAsync(string filename, JArray titles) {
            
            var lines = titles.Select(t => t["title"].ToString());

            File.WriteAllLinesAsync(filename, lines);
        }

        delegate void SetTextCallback(string text);
        private void Log(string text) {
            // https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (TbLogs.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(Log);
                Invoke(d, new object[] { text });
            } else {
                TbLogs.AppendText(text + Environment.NewLine);
            }
        }

        AboutForm aboutForm;
        private void BtnAbout_Click(object sender, EventArgs e) {

            if (aboutForm == null || aboutForm.IsDisposed) {
                aboutForm = new AboutForm();
                aboutForm.Show();
            }
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void TabTVShows_Click(object sender, EventArgs e) {

        }

        private void DGVTVShows_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void TabMovies_Click(object sender, EventArgs e) {

        }

        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void TabNotFound_Click(object sender, EventArgs e) {

        }

        private void DGVNotFound_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void TabUnknown_Click(object sender, EventArgs e) {

        }

        private void DGVError_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void TabForbidden_Click(object sender, EventArgs e) {

        }

        private void DGVForbidden_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void TabLogs_Click(object sender, EventArgs e) {

        }

        private void TbLogs_TextChanged(object sender, EventArgs e) {

        }

        private void TbProgress_TextChanged(object sender, EventArgs e) {

        }

        private void LbProgress_Click(object sender, EventArgs e) {

        }
    }
}
