namespace GymFitnessOlympic.View.Dialog
{
    partial class FrmChonCa
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
            this.rdCaSang = new System.Windows.Forms.RadioButton();
            this.rdCaChieu = new System.Windows.Forms.RadioButton();
            this.rdCaToi = new System.Windows.Forms.RadioButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdCaSang
            // 
            this.rdCaSang.AutoSize = true;
            this.rdCaSang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCaSang.Location = new System.Drawing.Point(35, 3);
            this.rdCaSang.Name = "rdCaSang";
            this.rdCaSang.Size = new System.Drawing.Size(97, 28);
            this.rdCaSang.TabIndex = 0;
            this.rdCaSang.TabStop = true;
            this.rdCaSang.Text = "Ca sáng";
            this.rdCaSang.UseVisualStyleBackColor = true;
            this.rdCaSang.CheckedChanged += new System.EventHandler(this.rdCaSang_CheckedChanged);
            // 
            // rdCaChieu
            // 
            this.rdCaChieu.AutoSize = true;
            this.rdCaChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCaChieu.Location = new System.Drawing.Point(35, 41);
            this.rdCaChieu.Name = "rdCaChieu";
            this.rdCaChieu.Size = new System.Drawing.Size(103, 28);
            this.rdCaChieu.TabIndex = 0;
            this.rdCaChieu.TabStop = true;
            this.rdCaChieu.Text = "Ca chiều";
            this.rdCaChieu.UseVisualStyleBackColor = true;
            this.rdCaChieu.CheckedChanged += new System.EventHandler(this.rdCaChieu_CheckedChanged);
            // 
            // rdCaToi
            // 
            this.rdCaToi.AutoSize = true;
            this.rdCaToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCaToi.Location = new System.Drawing.Point(35, 84);
            this.rdCaToi.Name = "rdCaToi";
            this.rdCaToi.Size = new System.Drawing.Size(75, 28);
            this.rdCaToi.TabIndex = 0;
            this.rdCaToi.TabStop = true;
            this.rdCaToi.Text = "Ca tối";
            this.rdCaToi.UseVisualStyleBackColor = true;
            this.rdCaToi.CheckedChanged += new System.EventHandler(this.rdCaToi_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(106, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(156, 55);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Chọn";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdCaSang);
            this.panel1.Controls.Add(this.rdCaChieu);
            this.panel1.Controls.Add(this.rdCaToi);
            this.panel1.Location = new System.Drawing.Point(106, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 117);
            this.panel1.TabIndex = 2;
            // 
            // FrmChonCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmChonCa";
            this.Text = "FrmChonCa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCaSang;
        private System.Windows.Forms.RadioButton rdCaChieu;
        private System.Windows.Forms.RadioButton rdCaToi;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Panel panel1;

    }
}