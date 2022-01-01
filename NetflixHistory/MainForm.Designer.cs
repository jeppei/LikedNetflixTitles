
namespace NetflixHistory {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TabTVShows = new System.Windows.Forms.TabPage();
            this.DGVTVShows = new System.Windows.Forms.DataGridView();
            this.TabMovies = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.TabNotFound = new System.Windows.Forms.TabPage();
            this.DGVNotFound = new System.Windows.Forms.DataGridView();
            this.TabUnknown = new System.Windows.Forms.TabPage();
            this.DGVError = new System.Windows.Forms.DataGridView();
            this.TabForbidden = new System.Windows.Forms.TabPage();
            this.DGVForbidden = new System.Windows.Forms.DataGridView();
            this.TabLogs = new System.Windows.Forms.TabPage();
            this.TbLogs = new System.Windows.Forms.TextBox();
            this.BtnLoadNetflixHistory = new System.Windows.Forms.Button();
            this.TbProgress = new System.Windows.Forms.TextBox();
            this.LbProgress = new System.Windows.Forms.Label();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.TabTVShows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTVShows)).BeginInit();
            this.TabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.TabNotFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotFound)).BeginInit();
            this.TabUnknown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVError)).BeginInit();
            this.TabForbidden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForbidden)).BeginInit();
            this.TabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.TabTVShows);
            this.Tabs.Controls.Add(this.TabMovies);
            this.Tabs.Controls.Add(this.TabNotFound);
            this.Tabs.Controls.Add(this.TabUnknown);
            this.Tabs.Controls.Add(this.TabForbidden);
            this.Tabs.Controls.Add(this.TabLogs);
            this.Tabs.Location = new System.Drawing.Point(13, 42);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(898, 587);
            this.Tabs.TabIndex = 0;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // TabTVShows
            // 
            this.TabTVShows.Controls.Add(this.DGVTVShows);
            this.TabTVShows.Location = new System.Drawing.Point(4, 24);
            this.TabTVShows.Name = "TabTVShows";
            this.TabTVShows.Padding = new System.Windows.Forms.Padding(3);
            this.TabTVShows.Size = new System.Drawing.Size(890, 559);
            this.TabTVShows.TabIndex = 0;
            this.TabTVShows.Text = "TV Shows";
            this.TabTVShows.UseVisualStyleBackColor = true;
            this.TabTVShows.Click += new System.EventHandler(this.TabTVShows_Click);
            // 
            // DGVTVShows
            // 
            this.DGVTVShows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVTVShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTVShows.Location = new System.Drawing.Point(7, 7);
            this.DGVTVShows.Name = "DGVTVShows";
            this.DGVTVShows.RowTemplate.Height = 25;
            this.DGVTVShows.Size = new System.Drawing.Size(877, 546);
            this.DGVTVShows.TabIndex = 0;
            this.DGVTVShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTVShows_CellContentClick);
            // 
            // TabMovies
            // 
            this.TabMovies.Controls.Add(this.DGVMovies);
            this.TabMovies.Location = new System.Drawing.Point(4, 24);
            this.TabMovies.Name = "TabMovies";
            this.TabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.TabMovies.Size = new System.Drawing.Size(890, 559);
            this.TabMovies.TabIndex = 1;
            this.TabMovies.Text = "Movies";
            this.TabMovies.UseVisualStyleBackColor = true;
            this.TabMovies.Click += new System.EventHandler(this.TabMovies_Click);
            // 
            // DGVMovies
            // 
            this.DGVMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Location = new System.Drawing.Point(7, 7);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowTemplate.Height = 25;
            this.DGVMovies.Size = new System.Drawing.Size(877, 546);
            this.DGVMovies.TabIndex = 0;
            this.DGVMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // TabNotFound
            // 
            this.TabNotFound.Controls.Add(this.DGVNotFound);
            this.TabNotFound.Location = new System.Drawing.Point(4, 24);
            this.TabNotFound.Name = "TabNotFound";
            this.TabNotFound.Size = new System.Drawing.Size(890, 559);
            this.TabNotFound.TabIndex = 4;
            this.TabNotFound.Text = "Not found";
            this.TabNotFound.UseVisualStyleBackColor = true;
            this.TabNotFound.Click += new System.EventHandler(this.TabNotFound_Click);
            // 
            // DGVNotFound
            // 
            this.DGVNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNotFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNotFound.Location = new System.Drawing.Point(4, 4);
            this.DGVNotFound.Name = "DGVNotFound";
            this.DGVNotFound.RowTemplate.Height = 25;
            this.DGVNotFound.Size = new System.Drawing.Size(883, 552);
            this.DGVNotFound.TabIndex = 0;
            this.DGVNotFound.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNotFound_CellContentClick);
            // 
            // TabUnknown
            // 
            this.TabUnknown.Controls.Add(this.DGVError);
            this.TabUnknown.Location = new System.Drawing.Point(4, 24);
            this.TabUnknown.Name = "TabUnknown";
            this.TabUnknown.Size = new System.Drawing.Size(890, 559);
            this.TabUnknown.TabIndex = 2;
            this.TabUnknown.Text = "Unknown";
            this.TabUnknown.UseVisualStyleBackColor = true;
            this.TabUnknown.Click += new System.EventHandler(this.TabUnknown_Click);
            // 
            // DGVError
            // 
            this.DGVError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVError.Location = new System.Drawing.Point(4, 4);
            this.DGVError.Name = "DGVError";
            this.DGVError.RowTemplate.Height = 25;
            this.DGVError.Size = new System.Drawing.Size(883, 552);
            this.DGVError.TabIndex = 0;
            this.DGVError.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVError_CellContentClick);
            // 
            // TabForbidden
            // 
            this.TabForbidden.Controls.Add(this.DGVForbidden);
            this.TabForbidden.Location = new System.Drawing.Point(4, 24);
            this.TabForbidden.Name = "TabForbidden";
            this.TabForbidden.Size = new System.Drawing.Size(890, 559);
            this.TabForbidden.TabIndex = 5;
            this.TabForbidden.Text = "Forbidden";
            this.TabForbidden.UseVisualStyleBackColor = true;
            this.TabForbidden.Click += new System.EventHandler(this.TabForbidden_Click);
            // 
            // DGVForbidden
            // 
            this.DGVForbidden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVForbidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVForbidden.Location = new System.Drawing.Point(4, 4);
            this.DGVForbidden.Name = "DGVForbidden";
            this.DGVForbidden.RowTemplate.Height = 25;
            this.DGVForbidden.Size = new System.Drawing.Size(883, 552);
            this.DGVForbidden.TabIndex = 0;
            this.DGVForbidden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVForbidden_CellContentClick);
            // 
            // TabLogs
            // 
            this.TabLogs.Controls.Add(this.TbLogs);
            this.TabLogs.Location = new System.Drawing.Point(4, 24);
            this.TabLogs.Name = "TabLogs";
            this.TabLogs.Size = new System.Drawing.Size(890, 559);
            this.TabLogs.TabIndex = 3;
            this.TabLogs.Text = "Logs";
            this.TabLogs.UseVisualStyleBackColor = true;
            this.TabLogs.Click += new System.EventHandler(this.TabLogs_Click);
            // 
            // TbLogs
            // 
            this.TbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLogs.Location = new System.Drawing.Point(4, 4);
            this.TbLogs.Multiline = true;
            this.TbLogs.Name = "TbLogs";
            this.TbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbLogs.Size = new System.Drawing.Size(883, 552);
            this.TbLogs.TabIndex = 0;
            this.TbLogs.TextChanged += new System.EventHandler(this.TbLogs_TextChanged);
            // 
            // BtnLoadNetflixHistory
            // 
            this.BtnLoadNetflixHistory.Location = new System.Drawing.Point(13, 13);
            this.BtnLoadNetflixHistory.Name = "BtnLoadNetflixHistory";
            this.BtnLoadNetflixHistory.Size = new System.Drawing.Size(141, 23);
            this.BtnLoadNetflixHistory.TabIndex = 1;
            this.BtnLoadNetflixHistory.Text = "Load Netflix Ratings";
            this.BtnLoadNetflixHistory.UseVisualStyleBackColor = true;
            this.BtnLoadNetflixHistory.Click += new System.EventHandler(this.BtnLoadNetflixHistory_Click);
            // 
            // TbProgress
            // 
            this.TbProgress.Location = new System.Drawing.Point(243, 14);
            this.TbProgress.Name = "TbProgress";
            this.TbProgress.Size = new System.Drawing.Size(100, 23);
            this.TbProgress.TabIndex = 2;
            this.TbProgress.TextChanged += new System.EventHandler(this.TbProgress_TextChanged);
            // 
            // LbProgress
            // 
            this.LbProgress.AutoSize = true;
            this.LbProgress.Location = new System.Drawing.Point(185, 17);
            this.LbProgress.Name = "LbProgress";
            this.LbProgress.Size = new System.Drawing.Size(55, 15);
            this.LbProgress.TabIndex = 3;
            this.LbProgress.Text = "Progress:";
            this.LbProgress.Click += new System.EventHandler(this.LbProgress_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbout.Location = new System.Drawing.Point(826, 14);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(75, 23);
            this.BtnAbout.TabIndex = 4;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 641);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.LbProgress);
            this.Controls.Add(this.TbProgress);
            this.Controls.Add(this.BtnLoadNetflixHistory);
            this.Controls.Add(this.Tabs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.TabTVShows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTVShows)).EndInit();
            this.TabMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.TabNotFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotFound)).EndInit();
            this.TabUnknown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVError)).EndInit();
            this.TabForbidden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVForbidden)).EndInit();
            this.TabLogs.ResumeLayout(false);
            this.TabLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TabTVShows;
        private System.Windows.Forms.DataGridView DGVTVShows;
        private System.Windows.Forms.TabPage TabMovies;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.TabPage TabUnknown;
        private System.Windows.Forms.DataGridView DGVError;
        private System.Windows.Forms.TabPage TabLogs;
        private System.Windows.Forms.TextBox TbLogs;
        private System.Windows.Forms.Button BtnLoadNetflixHistory;
        private System.Windows.Forms.TextBox TbProgress;
        private System.Windows.Forms.Label LbProgress;
        private System.Windows.Forms.TabPage TabNotFound;
        private System.Windows.Forms.DataGridView DGVNotFound;
        private System.Windows.Forms.TabPage TabForbidden;
        private System.Windows.Forms.DataGridView DGVForbidden;
        private System.Windows.Forms.Button BtnAbout;
    }
}

