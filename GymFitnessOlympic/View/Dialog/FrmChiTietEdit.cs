using GymFitnessOlympic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmChiTietEdit : Form
    {
       public ChiTietHoaDon ct;
        public FrmChiTietEdit(ChiTietHoaDon c)
        {
            InitializeComponent();
            ct = c;
            txtGia.Text = ct.Gia.ToString();
            spnSoLuong.Value = ct.SoLuong;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (spnSoLuong.Value <= 0)
            {
                dxErrorProvider1.SetError(spnSoLuong, "Số lượng phải là số nguyên dương");
                spnSoLuong.Focus();
                return;
            }
            int soLuong = 1;
            if (!int.TryParse(spnSoLuong.Text, out soLuong))
            {
                dxErrorProvider1.SetError(spnSoLuong, "Số lượng quá lớn");
                spnSoLuong.Focus();
                return;
            }
            int gia;
            if (!int.TryParse(txtGia.Text, out gia) || (gia % 500 != 0) || gia <= 0)
            {
                txtGia.Focus();
                dxErrorProvider1.SetError(txtGia, "Giá không hợp lệ");
                return;
            }
            ct.Gia = gia;
            ct.SoLuong = int.Parse(spnSoLuong.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
