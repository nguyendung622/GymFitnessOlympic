namespace GymFitnessOlympic.View.UserControls.QuanLy
{
    partial class QLGoiTap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrGoiTap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cbbGYM = new System.Windows.Forms.ComboBox();
            this.cbbPhong1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGoiTap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhong1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrGoiTap
            // 
            this.dgrGoiTap.AllowUserToAddRows = false;
            this.dgrGoiTap.AllowUserToDeleteRows = false;
            this.dgrGoiTap.AllowUserToResizeColumns = false;
            this.dgrGoiTap.AllowUserToResizeRows = false;
            this.dgrGoiTap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrGoiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrGoiTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgrGoiTap.Location = new System.Drawing.Point(3, 168);
            this.dgrGoiTap.MultiSelect = false;
            this.dgrGoiTap.Name = "dgrGoiTap";
            this.dgrGoiTap.ReadOnly = true;
            this.dgrGoiTap.RowHeadersVisible = false;
            this.dgrGoiTap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrGoiTap.Size = new System.Drawing.Size(815, 242);
            this.dgrGoiTap.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TenGoiTap";
            this.Column1.HeaderText = "Tên gói tập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoThang";
            this.Column3.HeaderText = "Số tháng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Gia";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GymFitnessOlympic.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(116, 112);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GymFitnessOlympic.Properties.Resources.Edit;
            this.btnSua.Location = new System.Drawing.Point(298, 112);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GymFitnessOlympic.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(485, 112);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 38);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbGYM
            // 
            this.cbbGYM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGYM.FormattingEnabled = true;
            this.cbbGYM.Items.AddRange(new object[] {
            "GYM",
            "SAUNA"});
            this.cbbGYM.Location = new System.Drawing.Point(53, 20);
            this.cbbGYM.Name = "cbbGYM";
            this.cbbGYM.Size = new System.Drawing.Size(121, 21);
            this.cbbGYM.TabIndex = 2;
            this.cbbGYM.SelectedIndexChanged += new System.EventHandler(this.cbbGYM_SelectedIndexChanged);
            // 
            // cbbPhong1
            // 
            this.cbbPhong1.Location = new System.Drawing.Point(320, 23);
            this.cbbPhong1.Name = "cbbPhong1";
            this.cbbPhong1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbPhong1.Size = new System.Drawing.Size(164, 20);
            this.cbbPhong1.TabIndex = 3;
            this.cbbPhong1.SelectedIndexChanged += new System.EventHandler(this.cbbPhong1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng tập";
            // 
            // QLGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPhong1);
            this.Controls.Add(this.cbbGYM);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrGoiTap);
            this.Name = "QLGoiTap";
            ((System.ComponentModel.ISupportInitialize)(this.dgrGoiTap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhong1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrGoiTap;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.ComboBox cbbGYM;
        private DevExpress.XtraEditors.ComboBoxEdit cbbPhong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
