using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixHistory {
    public partial class AboutForm : Form {

        private class Filename {
            public const string readMe = "README.txt";
        }

        public AboutForm() {
            InitializeComponent();
            string content = File.ReadAllText(Filename.readMe);
            LbAbout.Text = content;
        }
    }
}
