using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.View.Dialog;

namespace GymFitnessOlympic.View.UserControls.QuanLy
{
    public partial class QLGoiTap : UserControl
    {
        List<GoiTap> all;

        public QLGoiTap()
        {
            InitializeComponent();
            dgrGoiTap.AutoGenerateColumns = false;
            loadData();
            DataFiller.fillPhongCombo(cbbPhong1);
            if (cbbPhong1.Properties.Items.Count > 0)
            {
                cbbPhong1.SelectedIndex = 0;
            }
            else {
                cbbPhong1.Enabled = false;
            }
            cbbGYM.SelectedIndex = 0;
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrGoiTap.SelectedRows.Count > 0)
            {
                var g = (GoiTap)dgrGoiTap.SelectedRows[0].DataBoundItem;
                if (GoiTapController.Delete(g.MaGoiTap) == CODE_RESULT_RETURN.ThanhCong)
                {
                    loadData();
                }
            }
            else {
                MessageBox.Show("Chọn một gói");

            }
        }

        void updateTable(List<GoiTap> li) {
            dgrGoiTap.DataSource = li;
        }

        private void loadData()
        {
            var type = cbbGYM.SelectedIndex == 0 ? 1 : 2;
            var phong = (PhongTap)cbbPhong1.SelectedItem;
            if (phong != null)
            {
                all = GoiTapController.GetList(type, phong.MaPhongTap);
                updateTable(all);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmGoiTapEdit f = new FrmGoiTapEdit();
            if (f.ShowDialog() == DialogResult.OK) {
                loadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrGoiTap.SelectedRows.Count > 0)
            {
                FrmGoiTapEdit f = new FrmGoiTapEdit((GoiTap)dgrGoiTap.SelectedRows[0].DataBoundItem);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
                
            }
            else
            {
                MessageBox.Show("Chọn một gói");

            }
        }

        private void cbbGYM_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void cbbPhong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
