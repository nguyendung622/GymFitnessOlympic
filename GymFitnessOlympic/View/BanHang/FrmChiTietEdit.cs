using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NhaHang;
using TanHongPhat;
using GymFitnessOlympic.Models;

namespace TapHoaCode.GUI.Form1.BanHang
{
    public partial class FrmChiTietEdit : DevExpress.XtraEditors.XtraForm
    {
        ChiTietHoaDon c;
        public FrmChiTietEdit(ChiTietHoaDon c1= null)
        {
            InitializeComponent();
            c = c1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int gia;
            if(!int.TryParse(txtDG.Text, out gia)){
                dxErrorProvider1.SetError(txtDG,"Giá phải là số");
                txtDG.Focus();
                return;
            }
            if (gia < 0) {
                dxErrorProvider1.SetError(txtDG, "Giá phải là số nguyên dương");
                txtDG.Focus();
                return;
            }
            if (txtSL.Value < 0)
            {
                dxErrorProvider1.SetError(txtSL, "Số lượng phải là số nguyên dương");
                txtSL.Focus();
                return;
            }
            c.Gia = int.Parse(txtDG.Text);
            c.SoLuong = int.Parse(txtSL.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmChiTietEdit_Load(object sender, EventArgs e)
        {
            //txtMaHang.Text = c.MaSanPham.ToString();
            txtTenHang.Text = c.SanPham.TenSanPham;
            txtSL.Text = c.SoLuong.ToString();
            txtDG.Text = c.Gia.ToString();
        }
    }
}