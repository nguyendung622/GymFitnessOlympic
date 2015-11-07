using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.View.Utils;
using GymFitnessOlympic.Models.Util;

namespace GymFitnessOlympic.View.Systems
{
    public partial class FormLogin : BaseDialog
    {
        private const string HKEYAPP = "HKEY_CURRENT_USER\\Software\\GymFitness";
        private NhanVien m_User = null;
        public NhanVien User
        {
            get { return m_User; }
            private set { m_User = value; }
        }

        public FormLogin()
        {
            InitializeComponent();
            txtTenDangNhap.Text = "";
            try
            {
                txtTenDangNhap.Text = Microsoft.Win32.Registry.GetValue(HKEYAPP, "LastUserName", "").ToString();
            }
            catch { }
            txtMatKhau.Text = "";
            if (!string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
                this.ActiveControl = txtMatKhau;
            else
                this.ActiveControl = txtTenDangNhap;
            //test
            txtMatKhau.Text = txtTenDangNhap.Text = "admin";
            btnDongY_Click(null, null);
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text;
            var matKhau = txtMatKhau.Text;

            var bw = new BackgroundWorker();
            bw.DoWork += (oSender, oE) =>
            {
                oE.Result = NhanVienController.Login(tenDangNhap, matKhau);
            };
            bw.RunWorkerCompleted += (oSender, oE) =>
            {
                if (this.Visible == false)
                    return;
                picProgress.Visible = false;
                btnDongY.Enabled = true;
                if (oE.Error != null)
                {
                    Utils.DialogUtils.ShowMessage("Lỗi trong quá trình đăng nhập " + oE.Error.Message);
                }
                else
                {
                    if (oE.Result == null || !(oE.Result is NhanVien))
                    {
                        Utils.DialogUtils.ShowMessage("Thông tin đăng nhập không hợp lệ");
                        txtMatKhau.Clear();
                        txtTenDangNhap.Focus();
                    }
                    else //if (this.NguoiSuDung != null)
                    {
                        this.User = oE.Result as NhanVien;
                        Login1.TaiKhoanHienTai = User;
                        //Kiểm tra người sử dụng còn có quyến sử dụng hệ thống hay không
                        //if (this.User.IsActive == false)
                        //{
                        //    Utils.DialogUtils.ShowMessage("Bạn đã bị thu quyền sử dụng trên hệ thống.\n\rVui lòng liên hệ với quản trị viên");
                        //    txtMatKhau.Clear();
                        //    txtTenDangNhap.Focus();
                        //    this.User = null;
                        //}
                        //else
                        //{
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            this.Close();
                        //}
                    }
                }
            };
            picProgress.Visible = true;
            btnDongY.Enabled = false;
            bw.RunWorkerAsync();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btnDongY.PerformClick();
        }

        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.F12)
            {
                var frm = new FormSetConnectionString()
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    TopMost = true
                };
                frm.ShowDialog();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Microsoft.Win32.Registry.SetValue(HKEYAPP, "LastUserName", txtTenDangNhap.Text.Trim());
            }
            catch { }
        }
    }
}
