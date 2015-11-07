using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Linq;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.Models.Util;


namespace GymFitnessOlympic.View.ActForm
{
    public partial class FrmBanHang1 : UserControl
    {
        List<SanPham> allSanPham;
        HoaDon hoaDon;

        public FrmBanHang1()
        {
            InitializeComponent();
            int phongID = Login1.GetPhongHienTai().MaPhongTap;
            allSanPham = SanPhamController.GetList(phongID);
            dgrChiTiet.AutoGenerateColumns = false;
            dgrChiTiet.AutoGenerateColumns = false;
            dgrChiTiet = new DataGridView();
            loadListSanPham(allSanPham);
            hoaDon = new HoaDon();
            
        }

        void loadListSanPham(List<SanPham> li) {
    
            lbSanPham.DataSource = li;
        }

        void updateTable() {
            dgrChiTiet.DataSource = hoaDon.DanhSachChiTiet;
            dgrChiTiet.Update();
            int n = dgrChiTiet.RowCount;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (spnSoLuong.Value <= 0)
            {
                dxErrorProvider1.SetError(spnSoLuong, "Số lượng phải là số nguyên dương");
                spnSoLuong.Focus();
                return;
            }
            int gia ;
            if(!int.TryParse(txtGia.Text, out gia) || (gia % 500 != 0) || gia <=0){
                txtGia.Focus();
                dxErrorProvider1.SetError(txtGia,"Giá không hợp lệ");
                return;
            }
            if (lbSanPham.SelectedItem != null) {
                var sp = (SanPham)lbSanPham.SelectedItem;
                int soLuong = int.Parse(spnSoLuong.Text);
                ChiTietHoaDon c = new ChiTietHoaDon() { 
                    Gia = gia ,
                    MaSanPham = sp.MaSanPham,
                    SoLuong = soLuong, SanPham = sp

                };
                var old = hoaDon.DanhSachChiTiet.FirstOrDefault(c1=>c1.MaSanPham == c.MaSanPham);
                if (old != null)
                {
                    old.SoLuong += c.SoLuong;
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        hoaDon.DanhSachChiTiet.Add(c);
                    }
                }
            }
            updateTable();
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            if (dgrChiTiet.SelectedRows.Count > 0) { 
                var c = dgrChiTiet.SelectedRows[0].Index;
                hoaDon.DanhSachChiTiet.RemoveAt(c);
                updateTable();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrChiTiet.SelectedRows.Count > 0) {
                var c = (ChiTietHoaDon)dgrChiTiet.SelectedRows[0].DataBoundItem;
                FrmChiTietEdit f = new FrmChiTietEdit(c);
                f.FormClosing += f_FormClosing;
                if (f.ShowDialog() == DialogResult.OK) {
                    MessageBox.Show(c.Gia.ToString());
                }
            }
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            var f = (FrmChiTietEdit)sender;
            if (f.DialogResult == DialogResult.OK)
            {
                var ct = hoaDon.DanhSachChiTiet.FirstOrDefault(c => c.MaSanPham == f.ct.MaSanPham);
                ct = f.ct;
                updateTable();
            }
        }

        private void lbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSanPham.SelectedItem != null) {
                var sp = (SanPham)lbSanPham.SelectedItem;
                txtTenSanPham.Text
                     = sp.TenSanPham;
                txtGia.Text = sp.Gia.ToString();
                spnSoLuong.Text = "1";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrChiTiet.SelectedRows.Count > 0)
            {
                var c = (ChiTietHoaDon)dgrChiTiet.SelectedRows[0].DataBoundItem;
                hoaDon.DanhSachChiTiet.Remove(c);
                updateTable();
            }
        }

        private void dgrChiTiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //var ct =(ChiTietHoaDon) dgrChiTiet.SelectedRows[0].DataBoundItem;
            //switch (e.ColumnIndex) { 
            //    case 0:
            //        e.Value = ct.SanPham.TenSanPham;
            //        break;
               
            //}
        }

        private void dgrChiTiet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(dgrChiTiet.RowCount.ToString());
        }
    }
}
