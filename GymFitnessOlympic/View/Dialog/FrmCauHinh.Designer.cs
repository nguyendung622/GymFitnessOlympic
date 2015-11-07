namespace GymFitnessOlympic.View.Dialog
{
    partial class FrmCauHinh
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.spnBaoSinhNhat = new DevExpress.XtraEditors.SpinEdit();
            this.spnBaoHetHan = new DevExpress.XtraEditors.SpinEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnGioLamViec = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnBaoSinhNhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBaoHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGioLamViec);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.spnBaoSinhNhat);
            this.groupBox2.Controls.Add(this.spnBaoHetHan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông báo khi sắp đến ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Báo sinh nhật";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Báo thẻ sắp hết hạn";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // spnBaoSinhNhat
            // 
            this.spnBaoSinhNhat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnBaoSinhNhat.Location = new System.Drawing.Point(232, 78);
            this.spnBaoSinhNhat.Name = "spnBaoSinhNhat";
            this.spnBaoSinhNhat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnBaoSinhNhat.Properties.Appearance.Options.UseFont = true;
            this.spnBaoSinhNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnBaoSinhNhat.Size = new System.Drawing.Size(47, 26);
            this.spnBaoSinhNhat.TabIndex = 1;
            this.spnBaoSinhNhat.EditValueChanged += new System.EventHandler(this.spnBaoSinhNhat_EditValueChanged);
            // 
            // spnBaoHetHan
            // 
            this.spnBaoHetHan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnBaoHetHan.Location = new System.Drawing.Point(232, 28);
            this.spnBaoHetHan.Name = "spnBaoHetHan";
            this.spnBaoHetHan.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnBaoHetHan.Properties.Appearance.Options.UseFont = true;
            this.spnBaoHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnBaoHetHan.Size = new System.Drawing.Size(47, 26);
            this.spnBaoHetHan.TabIndex = 1;
            this.spnBaoHetHan.EditValueChanged += new System.EventHandler(this.spnBaoHetHan_EditValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(51, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 45);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(238, 225);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 45);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giờ làm việc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGioLamViec
            // 
            this.btnGioLamViec.Location = new System.Drawing.Point(232, 129);
            this.btnGioLamViec.Name = "btnGioLamViec";
            this.btnGioLamViec.Size = new System.Drawing.Size(75, 23);
            this.btnGioLamViec.TabIndex = 2;
            this.btnGioLamViec.Text = "Chỉnh sửa...";
            this.btnGioLamViec.Click += new System.EventHandler(this.btnGioLamViec_Click);
            // 
            // FrmCauHinh
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(431, 282);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmCauHinh";
            this.Text = "FrmCauHinh";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnBaoSinhNhat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnBaoHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SpinEdit spnBaoSinhNhat;
        private DevExpress.XtraEditors.SpinEdit spnBaoHetHan;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnGioLamViec;
        private System.Windows.Forms.Label label1;


    }
}