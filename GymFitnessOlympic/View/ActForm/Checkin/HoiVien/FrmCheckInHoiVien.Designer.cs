namespace GymFitnessOlympic.View.MainForms
{
    partial class FrmCheckinHoiVien
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
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.btnKiemTra = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPT_SoNgayConLai = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblPT_NgayHetHan = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPT_GiaHanCuoi = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnGiaHan = new DevExpress.XtraEditors.SimpleButton();
            this.lblChucNang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(34, 135);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(622, 40);
            this.txtMa.TabIndex = 4;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(679, 138);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(130, 37);
            this.btnKiemTra.TabIndex = 5;
            this.btnKiemTra.Text = "Kiểm tra thẻ";
            this.btnKiemTra.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.label12);
            this.groupControl5.Controls.Add(this.lblPT_SoNgayConLai);
            this.groupControl5.Controls.Add(this.label16);
            this.groupControl5.Controls.Add(this.lblPT_NgayHetHan);
            this.groupControl5.Controls.Add(this.label18);
            this.groupControl5.Controls.Add(this.lblPT_GiaHanCuoi);
            this.groupControl5.Location = new System.Drawing.Point(513, 204);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(296, 135);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Phòng tập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lần gia hạn cuối";
            // 
            // lblPT_SoNgayConLai
            // 
            this.lblPT_SoNgayConLai.AutoSize = true;
            this.lblPT_SoNgayConLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT_SoNgayConLai.ForeColor = System.Drawing.Color.Green;
            this.lblPT_SoNgayConLai.Location = new System.Drawing.Point(187, 94);
            this.lblPT_SoNgayConLai.Name = "lblPT_SoNgayConLai";
            this.lblPT_SoNgayConLai.Size = new System.Drawing.Size(82, 19);
            this.lblPT_SoNgayConLai.TabIndex = 3;
            this.lblPT_SoNgayConLai.Text = "Không rõ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ngày hết hạn";
            // 
            // lblPT_NgayHetHan
            // 
            this.lblPT_NgayHetHan.AutoSize = true;
            this.lblPT_NgayHetHan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT_NgayHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPT_NgayHetHan.Location = new System.Drawing.Point(186, 61);
            this.lblPT_NgayHetHan.Name = "lblPT_NgayHetHan";
            this.lblPT_NgayHetHan.Size = new System.Drawing.Size(82, 19);
            this.lblPT_NgayHetHan.TabIndex = 3;
            this.lblPT_NgayHetHan.Text = "Không rõ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 23);
            this.label18.TabIndex = 1;
            this.label18.Text = "Số ngày còn lại";
            // 
            // lblPT_GiaHanCuoi
            // 
            this.lblPT_GiaHanCuoi.AutoSize = true;
            this.lblPT_GiaHanCuoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT_GiaHanCuoi.ForeColor = System.Drawing.Color.Purple;
            this.lblPT_GiaHanCuoi.Location = new System.Drawing.Point(186, 26);
            this.lblPT_GiaHanCuoi.Name = "lblPT_GiaHanCuoi";
            this.lblPT_GiaHanCuoi.Size = new System.Drawing.Size(82, 19);
            this.lblPT_GiaHanCuoi.TabIndex = 2;
            this.lblPT_GiaHanCuoi.Text = "Không rõ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblTen);
            this.groupControl1.Controls.Add(this.lblThongBao);
            this.groupControl1.Controls.Add(this.lblKetQua);
            this.groupControl1.Location = new System.Drawing.Point(34, 204);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 195);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Kết quả";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(5, 97);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(105, 19);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Chưa rõ tên";
            this.lblTen.Visible = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(5, 133);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(323, 19);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "Thẻ của bạn còn 3 ngày nữa là hết hạn";
            this.lblThongBao.Visible = false;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(6, 31);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(229, 42);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = "Thẻ còn hạn";
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(513, 345);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(296, 54);
            this.btnGiaHan.TabIndex = 5;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // lblChucNang
            // 
            this.lblChucNang.AutoSize = true;
            this.lblChucNang.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucNang.Location = new System.Drawing.Point(30, 37);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Size = new System.Drawing.Size(458, 58);
            this.lblChucNang.TabIndex = 2;
            this.lblChucNang.Text = "Check in Thẻ GYM";
            this.lblChucNang.Visible = false;
            // 
            // FrmCheckinHoiVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 420);
            this.Controls.Add(this.lblChucNang);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.txtMa);
            this.Name = "FrmCheckinHoiVien";
            this.Load += new System.EventHandler(this.FrmCheckinHoiVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.SimpleButton btnKiemTra;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPT_SoNgayConLai;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPT_NgayHetHan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPT_GiaHanCuoi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblThongBao;
        private DevExpress.XtraEditors.SimpleButton btnGiaHan;
        private System.Windows.Forms.Label lblChucNang;
        private System.Windows.Forms.Label lblTen;

    }
}