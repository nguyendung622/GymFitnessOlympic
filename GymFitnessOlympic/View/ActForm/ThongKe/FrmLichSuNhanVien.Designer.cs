namespace GymFitnessOlympic.View.ActForm.ThongKe
{
    partial class FrmLichSuNhanVien
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
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.cbbCheDoLoc = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbbTheoQuyNam = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.rdTheoThang = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.rdTheoQuy = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTheoThangThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdTheoKhoangNgay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTheoThangNam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbInOut = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTheoQuyQuy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(514, 141);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(167, 51);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Lọc";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbbCheDoLoc
            // 
            this.cbbCheDoLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCheDoLoc.FormattingEnabled = true;
            this.cbbCheDoLoc.Items.AddRange(new object[] {
            "Theo tên/Mã thẻ",
            "Theo tên",
            "Theo mã thẻ"});
            this.cbbCheDoLoc.Location = new System.Drawing.Point(13, 144);
            this.cbbCheDoLoc.Name = "cbbCheDoLoc";
            this.cbbCheDoLoc.Size = new System.Drawing.Size(121, 21);
            this.cbbCheDoLoc.TabIndex = 13;
            this.cbbCheDoLoc.SelectedIndexChanged += new System.EventHandler(this.cbbMode_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(158, 144);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(334, 20);
            this.txtTim.TabIndex = 12;
            this.txtTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim_KeyPress);
            // 
            // cbbTheoQuyNam
            // 
            this.cbbTheoQuyNam.FormattingEnabled = true;
            this.cbbTheoQuyNam.Location = new System.Drawing.Point(250, 79);
            this.cbbTheoQuyNam.Name = "cbbTheoQuyNam";
            this.cbbTheoQuyNam.Size = new System.Drawing.Size(80, 21);
            this.cbbTheoQuyNam.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(532, 74);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // rdTheoThang
            // 
            this.rdTheoThang.AutoSize = true;
            this.rdTheoThang.Checked = true;
            this.rdTheoThang.Location = new System.Drawing.Point(14, 16);
            this.rdTheoThang.Name = "rdTheoThang";
            this.rdTheoThang.Size = new System.Drawing.Size(80, 17);
            this.rdTheoThang.TabIndex = 0;
            this.rdTheoThang.TabStop = true;
            this.rdTheoThang.Text = "Theo tháng";
            this.rdTheoThang.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(532, 48);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 3;
            // 
            // rdTheoQuy
            // 
            this.rdTheoQuy.AutoSize = true;
            this.rdTheoQuy.Location = new System.Drawing.Point(206, 16);
            this.rdTheoQuy.Name = "rdTheoQuy";
            this.rdTheoQuy.Size = new System.Drawing.Size(141, 17);
            this.rdTheoQuy.TabIndex = 0;
            this.rdTheoQuy.Text = "Theo quý (hoặc cả năm)";
            this.rdTheoQuy.UseVisualStyleBackColor = true;
            this.rdTheoQuy.CheckedChanged += new System.EventHandler(this.rdTheoQuy_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đến ngày";
            // 
            // cbbTheoThangThang
            // 
            this.cbbTheoThangThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoThangThang.FormattingEnabled = true;
            this.cbbTheoThangThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbTheoThangThang.Location = new System.Drawing.Point(64, 52);
            this.cbbTheoThangThang.Name = "cbbTheoThangThang";
            this.cbbTheoThangThang.Size = new System.Drawing.Size(80, 21);
            this.cbbTheoThangThang.TabIndex = 1;
            this.cbbTheoThangThang.SelectedIndexChanged += new System.EventHandler(this.cbbTheoThangThang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm";
            // 
            // rdTheoKhoangNgay
            // 
            this.rdTheoKhoangNgay.AutoSize = true;
            this.rdTheoKhoangNgay.Location = new System.Drawing.Point(462, 16);
            this.rdTheoKhoangNgay.Name = "rdTheoKhoangNgay";
            this.rdTheoKhoangNgay.Size = new System.Drawing.Size(115, 17);
            this.rdTheoKhoangNgay.TabIndex = 0;
            this.rdTheoKhoangNgay.Text = "Theo khoảng ngày";
            this.rdTheoKhoangNgay.UseVisualStyleBackColor = true;
            this.rdTheoKhoangNgay.CheckedChanged += new System.EventHandler(this.rdTheoKhoangNgay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm";
            // 
            // cbbTheoThangNam
            // 
            this.cbbTheoThangNam.FormattingEnabled = true;
            this.cbbTheoThangNam.Location = new System.Drawing.Point(64, 79);
            this.cbbTheoThangNam.Name = "cbbTheoThangNam";
            this.cbbTheoThangNam.Size = new System.Drawing.Size(80, 21);
            this.cbbTheoThangNam.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Check In / Check Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Từ ngày";
            // 
            // cbbInOut
            // 
            this.cbbInOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbInOut.FormattingEnabled = true;
            this.cbbInOut.Items.AddRange(new object[] {
            "Checkin/Checkout",
            "Check In",
            "Checkout"});
            this.cbbInOut.Location = new System.Drawing.Point(158, 176);
            this.cbbInOut.Name = "cbbInOut";
            this.cbbInOut.Size = new System.Drawing.Size(121, 21);
            this.cbbInOut.TabIndex = 14;
            this.cbbInOut.SelectedIndexChanged += new System.EventHandler(this.cbbInOut_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTheoQuyNam);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.rdTheoThang);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.rdTheoQuy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbTheoThangThang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdTheoKhoangNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbTheoThangNam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbTheoQuyQuy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ lọc";
            // 
            // cbbTheoQuyQuy
            // 
            this.cbbTheoQuyQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheoQuyQuy.FormattingEnabled = true;
            this.cbbTheoQuyQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbTheoQuyQuy.Location = new System.Drawing.Point(250, 52);
            this.cbbTheoQuyQuy.Name = "cbbTheoQuyQuy";
            this.cbbTheoQuyQuy.Size = new System.Drawing.Size(80, 21);
            this.cbbTheoQuyQuy.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.tgDung,
            this.tgThucTe,
            this.danhGia,
            this.chenhLech});
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(877, 211);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaThe";
            this.Column1.HeaderText = "Mã thẻ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "HoiVien.TenHoiVien";
            this.Column2.HeaderText = "Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IsCheckin";
            this.Column4.HeaderText = "Hành động";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Ca";
            this.Column5.HeaderText = "Ca";
            this.Column5.Name = "Column5";
            // 
            // tgDung
            // 
            this.tgDung.HeaderText = "Thời gian đúng";
            this.tgDung.Name = "tgDung";
            // 
            // tgThucTe
            // 
            this.tgThucTe.HeaderText = "Thời gian thực tế";
            this.tgThucTe.Name = "tgThucTe";
            // 
            // danhGia
            // 
            this.danhGia.DataPropertyName = "DanhGia";
            this.danhGia.HeaderText = "Đánh giá";
            this.danhGia.Name = "danhGia";
            // 
            // chenhLech
            // 
            this.chenhLech.DataPropertyName = "ChenhLech";
            this.chenhLech.HeaderText = "Số phút chênh lệch";
            this.chenhLech.Name = "chenhLech";
            // 
            // FrmLichSuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbbCheDoLoc);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbInOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLichSuNhanVien";
            this.Size = new System.Drawing.Size(901, 419);
            this.Load += new System.EventHandler(this.FrmLichSuNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.ComboBox cbbCheDoLoc;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbbTheoQuyNam;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.RadioButton rdTheoThang;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.RadioButton rdTheoQuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTheoThangThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdTheoKhoangNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTheoThangNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbInOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTheoQuyQuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn chenhLech;
    }
}