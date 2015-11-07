namespace TanHongPhat
{
    partial class FrmBanHang
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
            System.Windows.Forms.ColumnHeader columnHeader5;
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spnSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblTongTien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenHangTim = new DevExpress.XtraEditors.TextEdit();
            this.lbSanPham = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lvHangNhap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stt = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChiTietXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTietSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.spnSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSanPham)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 4;
            columnHeader5.Text = "Mã hàng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 197;
            // 
            // spnSoLuong
            // 
            this.spnSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnSoLuong.Location = new System.Drawing.Point(281, 202);
            this.spnSoLuong.Name = "spnSoLuong";
            this.spnSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnSoLuong.Size = new System.Drawing.Size(173, 20);
            this.spnSoLuong.TabIndex = 69;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(231, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Tên hàng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Enabled = false;
            this.lblTongTien.Location = new System.Drawing.Point(767, 288);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(98, 23);
            this.lblTongTien.TabIndex = 54;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // labelControl8
            // 
            this.labelControl8.Enabled = false;
            this.labelControl8.Location = new System.Drawing.Point(712, 293);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 49;
            this.labelControl8.Text = "Tổng tiền:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(281, 166);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(173, 20);
            this.txtTenHang.TabIndex = 46;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(281, 127);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(173, 20);
            this.txtMaHang.TabIndex = 45;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(281, 246);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(173, 20);
            this.txtDonGia.TabIndex = 44;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(231, 205);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(231, 249);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 48;
            this.labelControl4.Text = "Đơn giá";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 79;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtpThoiGian);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(231, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(223, 66);
            this.groupControl1.TabIndex = 68;
            this.groupControl1.Text = "Thông tin hóa đơn";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Location = new System.Drawing.Point(63, 27);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(153, 20);
            this.dtpThoiGian.TabIndex = 14;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(5, 31);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Ngày nhập";
            // 
            // txtTenHangTim
            // 
            this.txtTenHangTim.Location = new System.Drawing.Point(91, 49);
            this.txtTenHangTim.Name = "txtTenHangTim";
            this.txtTenHangTim.Size = new System.Drawing.Size(121, 20);
            this.txtTenHangTim.TabIndex = 43;
            this.txtTenHangTim.ToolTip = "Gõ để tìm kiếm, kết quả tức thì";
            this.txtTenHangTim.EditValueChanged += new System.EventHandler(this.txtTenHangTim_EditValueChanged);
            // 
            // lbSanPham
            // 
            this.lbSanPham.DisplayMember = "TenHang";
            this.lbSanPham.Location = new System.Drawing.Point(21, 102);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(170, 240);
            this.lbSanPham.TabIndex = 57;
            this.lbSanPham.SelectedIndexChanged += new System.EventHandler(this.lbHang_SelectedIndexChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(21, 83);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(143, 13);
            this.labelControl12.TabIndex = 51;
            this.labelControl12.Text = "Danh sách hàng thỏa yêu cầu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Tên hàng";
            // 
            // lvHangNhap
            // 
            this.lvHangNhap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHangNhap.FullRowSelect = true;
            this.lvHangNhap.Location = new System.Drawing.Point(476, 51);
            this.lvHangNhap.Name = "lvHangNhap";
            this.lvHangNhap.Size = new System.Drawing.Size(429, 215);
            this.lvHangNhap.TabIndex = 56;
            this.lvHangNhap.UseCompatibleStateImageBehavior = false;
            this.lvHangNhap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Tên hàng";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 87;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(231, 130);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 55;
            this.labelControl7.Text = "Mã hàng";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 486);
            this.tabControl1.TabIndex = 70;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.lbSanPham);
            this.tabPage1.Controls.Add(this.btnChiTietXoa);
            this.tabPage1.Controls.Add(this.btnChiTietSua);
            this.tabPage1.Controls.Add(this.lblTongTien);
            this.tabPage1.Controls.Add(this.spnSoLuong);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Controls.Add(this.labelControl7);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.labelControl6);
            this.tabPage1.Controls.Add(this.lvHangNhap);
            this.tabPage1.Controls.Add(this.labelControl12);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.txtTenHangTim);
            this.tabPage1.Controls.Add(this.txtTenHang);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.txtMaHang);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.txtDonGia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn mới";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stt});
            this.statusStrip1.Location = new System.Drawing.Point(3, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 71;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "HD IMissU";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // stt
            // 
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(0, 17);
            // 
            // btnChiTietXoa
            // 
            this.btnChiTietXoa.Image = global::GymFitnessOlympic.Properties.Resources.delete;
            this.btnChiTietXoa.Location = new System.Drawing.Point(577, 6);
            this.btnChiTietXoa.Name = "btnChiTietXoa";
            this.btnChiTietXoa.Size = new System.Drawing.Size(100, 39);
            this.btnChiTietXoa.TabIndex = 63;
            this.btnChiTietXoa.Text = "Xóa";
            this.btnChiTietXoa.Click += new System.EventHandler(this.btnChiTietXoa_Click);
            // 
            // btnChiTietSua
            // 
            this.btnChiTietSua.Image = global::GymFitnessOlympic.Properties.Resources.Edit;
            this.btnChiTietSua.Location = new System.Drawing.Point(476, 6);
            this.btnChiTietSua.Name = "btnChiTietSua";
            this.btnChiTietSua.Size = new System.Drawing.Size(95, 39);
            this.btnChiTietSua.TabIndex = 62;
            this.btnChiTietSua.Text = "Sửa";
            this.btnChiTietSua.Click += new System.EventHandler(this.btnChiTietSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Image = global::GymFitnessOlympic.Properties.Resources.update;
            this.btnReset.Location = new System.Drawing.Point(495, 332);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(201, 52);
            this.btnReset.TabIndex = 66;
            this.btnReset.Text = "Hủy hóa đơn hiện tại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::GymFitnessOlympic.Properties.Resources.statistics1;
            this.btnSave.Location = new System.Drawing.Point(712, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 52);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Bán hàng";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(236, 332);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(223, 52);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm";
            this.btnThem.ToolTip = "Thêm mặt hàng vào danh sách nhập, một khi đã click, không\r\nthể thay đổi nhà cung " +
    "cấp được nữa, trừ khi click \"Làm lại từ đầu\"\r\nđể tạo phiếu nhập mới.";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmBanHang";
            this.Size = new System.Drawing.Size(923, 486);
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSanPham)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        public DevExpress.XtraEditors.SpinEdit spnSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.LabelControl lblTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.SimpleButton btnThem;
        public System.Windows.Forms.TextBox txtTenHang;
        public System.Windows.Forms.TextBox txtMaHang;
        public System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public System.Windows.Forms.DateTimePicker dtpThoiGian;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit txtTenHangTim;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnChiTietXoa;
        private DevExpress.XtraEditors.SimpleButton btnChiTietSua;
        public DevExpress.XtraEditors.ListBoxControl lbSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ListView lvHangNhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stt;
    }
}