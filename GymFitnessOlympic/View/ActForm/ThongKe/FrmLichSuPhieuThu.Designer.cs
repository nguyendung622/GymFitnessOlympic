namespace GymFitnessOlympic.View.ActForm
{
    partial class FrmLichSuPhieuThu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTheoQuyQuy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(747, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ lọc";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Từ ngày";
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
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(866, 228);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaPhieuThu";
            this.Column1.HeaderText = "Mã phiếu thu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "NgayLap";
            this.Column2.HeaderText = "Ngày lập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SoTien";
            this.Column3.HeaderText = "Số tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NhanVien";
            this.Column4.HeaderText = "Nhân viên lập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HoiVien";
            this.Column5.HeaderText = "Cho hội viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(577, 138);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 37);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Lọc";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phòng";
            // 
            // cbbPhong
            // 
            this.cbbPhong.Location = new System.Drawing.Point(76, 147);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbPhong.Size = new System.Drawing.Size(190, 20);
            this.cbbPhong.TabIndex = 17;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FrmLichSuPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLichSuPhieuThu";
            this.Size = new System.Drawing.Size(890, 446);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTheoQuyQuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit cbbPhong;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}