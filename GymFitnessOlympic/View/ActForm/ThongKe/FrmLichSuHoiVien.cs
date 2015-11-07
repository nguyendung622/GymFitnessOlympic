using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.MainForms
{
    public partial class FrmLichSuHoiVien : UserControl
    {
        List<HistoryHoiVien> danhSachLichSu;
        bool isGym;
        public FrmLichSuHoiVien(bool isGYM = true)
        {
            InitializeComponent();
            this.isGym = isGYM;
            dataGridView1.AutoGenerateColumns = false;

            cbbGYM.SelectedIndex = isGYM ? 0 : 1;
            loadData();
            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoQuyNam.Items.Add(i);
                cbbTheoThangNam.Items.Add(i);

            }
            cbbTheoQuyNam.SelectedValue = cbbTheoThangNam.SelectedValue = DateTime.Now.Year;
            cbbTheoThangThang.SelectedValue = DateTime.Now.Month;
            cbbTheoQuyQuy.SelectedIndex = cbbTheoQuyNam.SelectedIndex = cbbTheoThangNam.SelectedIndex
                = cbbTheoThangThang.SelectedIndex = cbbMode.SelectedIndex = 0;
        }

        void loadData()
        {

            var isGym = cbbGYM.SelectedIndex == 0;
            //danhSachLichSu = HistoryHoiVienController.GetList(Login.GetPhongHienTai().MaPhongTap, isGym);
            danhSachLichSu = HistoryHoiVienController.GetList(1, isGym);
            updateTable(danhSachLichSu);
        }
        void updateTable(List<HistoryHoiVien> li)
        {
            dataGridView1.DataSource = li;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            loc();
        }

        void loc()
        {
            try
            {
                DateTime start = new DateTime(), end = new DateTime();
                if (rdTheoThang.Checked)
                {
                    int month = int.Parse(cbbTheoThangThang.Text.ToString());
                    int year = int.Parse(cbbTheoThangNam.Text.ToString());
                    start = new DateTime(year, month, 1);
                    end = start.AddMonths(1).AddDays(-1);
                }
                else if (rdTheoQuy.Checked)
                {
                    int year = int.Parse(cbbTheoQuyNam.Text);
                    switch (cbbTheoQuyQuy.SelectedIndex)
                    {
                        case 0:
                            start = new DateTime(year, 1, 1);
                            end = new DateTime(year, 3, 31);
                            break;
                        case 1:
                            start = new DateTime(year, 4, 1);
                            end = new DateTime(year, 6, 30);
                            break;
                        case 2:
                            start = new DateTime(year, 7, 1);
                            end = new DateTime(year, 9, 30);
                            break;
                        case 3:
                            start = new DateTime(year, 10, 1);
                            end = new DateTime(year, 12, 31);
                            break;
                    }
                }
                else if (rdTheoKhoangNgay.Checked)
                {
                    start = dtpFrom.Value;
                    end = dtpTo.Value;
                }
                IEnumerable<HistoryHoiVien> li = new List<HistoryHoiVien>();
                var st = txtTim.Text.ToUpper();
                switch (cbbMode.SelectedIndex)
                {
                    case 0:
                        li = danhSachLichSu.Where(h => h.HoiVien.MaGYM.ToUpper().Contains(st) || h.HoiVien.TenHoiVien.ToUpper().Contains(st)).ToList();
                        break;
                    case 1:
                        li = danhSachLichSu.Where(h => h.HoiVien.MaGYM.ToUpper().Contains(st));
                        break;
                    case 2:
                        li = danhSachLichSu.Where(h => h.HoiVien.TenHoiVien.ToUpper().Contains(st));
                        break;
                }
                
                li = li.Where(h => h.ThoiGian.CompareTo(start) >= 0 && h.ThoiGian.CompareTo(end) <= 0);
                updateTable(li.ToList());
            }
            catch { }
        }

        void locDuLieu(DateTime start, DateTime end, int cheDoTim = 0, int locTheo = 0, String queryString = "")
        {
            var li = new List<HistoryHoiVien>();
            switch (cheDoTim)
            {
                case 0:
                    break;
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var hvh = (HistoryHoiVien)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == 0)
            {
                e.Value = hvh.HoiVien.MaGYM;
            }
            if (e.ColumnIndex == 1)
            {
                e.Value = hvh.HoiVien.TenHoiVien;
            }
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnTim_Click(null, null);
            }
        }

        private void cbbTheoThangThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loc();
        }

        private void cbbTheoThangNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            loc();
        }

        private void rdTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            loc();
        }

        private void rdTheoQuy_CheckedChanged(object sender, EventArgs e)
        {
            loc();
        }

        private void rdTheoKhoangNgay_CheckedChanged(object sender, EventArgs e)
        {
            loc();
        }
    }
}
