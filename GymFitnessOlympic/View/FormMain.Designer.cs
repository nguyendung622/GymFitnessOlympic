namespace GymFitnessOlympic.View
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbMain = new System.Windows.Forms.Ribbon();
            this.pnMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rbMain
            // 
            this.rbMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbMain.Location = new System.Drawing.Point(0, 0);
            this.rbMain.Minimized = false;
            this.rbMain.Name = "rbMain";
            // 
            // 
            // 
            this.rbMain.OrbDropDown.BorderRoundness = 8;
            this.rbMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbMain.OrbDropDown.Name = "";
            this.rbMain.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.rbMain.OrbDropDown.TabIndex = 0;
            this.rbMain.OrbImage = null;
            this.rbMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.rbMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rbMain.Size = new System.Drawing.Size(912, 145);
            this.rbMain.TabIndex = 0;
            this.rbMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.rbMain.Text = "ribbon1";
            this.rbMain.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 145);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(912, 249);
            this.pnMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 394);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.rbMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ PHÒNG GYM & FITNESS OLYMPIC HUẾ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rbMain;
        private System.Windows.Forms.Panel pnMain;
    }
}