
namespace NetflixHistory {
    partial class AboutForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LbAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbAbout
            // 
            this.LbAbout.AutoSize = true;
            this.LbAbout.Location = new System.Drawing.Point(13, 13);
            this.LbAbout.Name = "LbAbout";
            this.LbAbout.Size = new System.Drawing.Size(40, 15);
            this.LbAbout.TabIndex = 0;
            this.LbAbout.Text = "About";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 847);
            this.Controls.Add(this.LbAbout);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAbout;
    }
}