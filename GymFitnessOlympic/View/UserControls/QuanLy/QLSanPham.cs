using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.View.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.UserControls.QuanLy
{
    public partial class QLSanPham : UserControl
    {
        List<SanPham> all;

        public QLSanPham()
        {
            InitializeComponent();
            DataFiller.fillPhongCombo(cbbPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmSanPhamEdit f = new FrmSanPhamEdit();
            if (f.ShowDialog() == DialogResult.OK) {
                loadData();
            }
        }

        void loadData()
        {
            var p = (PhongTap)cbbPhong.SelectedItem;
            if (p != null)
            {
                all = SanPhamController.GetList(p.MaPhongTap);
                updateTable(all);
            }
            //gridControl1.DataSource = all;
            txtTim.Text = "";
        }

        void updateTable(List<SanPham> li)
        {
            dgrHoiVien.DataSource = li;
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                var h = (SanPham)dgrHoiVien.SelectedRows[0].DataBoundItem;
                if (SanPhamController.Delete(h.MaSanPham) == CODE_RESULT_RETURN.ThanhCong)
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa");

                }
            }
            else
            {
                MessageBox.Show("Chọn một sản phẩm để xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                var h = (SanPham)dgrHoiVien.SelectedRows[0].DataBoundItem;
                FrmSanPhamEdit f = new FrmSanPhamEdit(h);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa");

                }
            }
            else
            {
                MessageBox.Show("Chọn một sản phẩm để chỉnh sửa");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var st = txtTimKiem.Text.Trim().ToUpper();
            var li = all.Where(s=>s.TenSanPham.ToUpper().Contains(st)).ToList();
            updateTable(li);
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnTim_Click(null, null);
            }
        }
    }
}
