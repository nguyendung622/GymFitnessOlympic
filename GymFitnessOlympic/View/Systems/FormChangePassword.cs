using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.View.Utils;
using GymFitnessOlympic.Models.Util;


namespace GymFitnessOlympic.View.Systems
{
    public partial class FormChangePassword : BaseDialog
    {
        private NhanVien m_NguoiSuDung;

        public FormChangePassword(NhanVien nguoiSuDung)
        {
            InitializeComponent();
            nguoiSuDung = Login1.GetTaiKhoanHienTai();
            if (nguoiSuDung == null)
            {
                throw new Exception("Tham số nguoiSuDung == NULL!");
            }
            else
            {
                txtTenDangNhap.Text = nguoiSuDung.UserName;
                cbxVaiTro.SelectedValue = nguoiSuDung.Quyen.MaQuyen;
                txtMatKhau.Focus();
                m_NguoiSuDung = nguoiSuDung;
            }
        }

        private void OnDongYClick(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhau.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string matKhauMoi2 = txtMatKhauMoi2.Text;
            errorNotity.Clear();
            var matKhauCuHash = CryptoMd5.MD5Hash(matKhauCu);
            if (matKhauCuHash != m_NguoiSuDung.Password)
            {
                errorNotity.SetError(txtMatKhau, "Mật khẩu cũ không đúng!");
                txtMatKhau.Focus();
                return;
            }

            if (matKhauMoi != matKhauMoi2)
            {
                errorNotity.SetError(txtMatKhauMoi, "Mật khẩu mới không khớp!");
                txtMatKhauMoi.Focus();
                return;
            }

            try
            {
                NhanVienController.ChangePassword(m_NguoiSuDung, matKhauMoi);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                DialogUtils.ShowError("Không thể đổi mật khẩu được!");
            }
        }

        private void txtMatKhauMoi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnDongY.PerformClick();
            }
        }
    }
}
