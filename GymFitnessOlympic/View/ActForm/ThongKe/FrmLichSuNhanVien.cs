using GymFitnessOlympic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models.Util;

namespace GymFitnessOlympic.View.ActForm.ThongKe
{
    public partial class FrmLichSuNhanVien : UserControl
    {
        List<HistoryNhanVien> danhSachLichSu;
        bool isGym;
        public FrmLichSuNhanVien(bool isGYM = true)
        {
            InitializeComponent();
            this.isGym = isGYM;
            dataGridView1.AutoGenerateColumns = false;

            cbbInOut.SelectedIndex = isGYM ? 0 : 1;
            loadData();
            loc();
            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoQuyNam.Items.Add(i);
                cbbTheoThangNam.Items.Add(i);

            }
            cbbTheoQuyNam.SelectedValue = cbbTheoThangNam.SelectedValue = DateTime.Now.Year;
            cbbTheoThangThang.SelectedValue = DateTime.Now.Month;
            cbbTheoQuyQuy.SelectedIndex = cbbTheoQuyNam.SelectedIndex = cbbTheoThangNam.SelectedIndex
                = cbbTheoThangThang.SelectedIndex = cbbCheDoLoc.SelectedIndex = 0;
        }

        private void FrmLichSuNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            loc();
        }

        private void cbbInOut_SelectedIndexChanged(object sender, EventArgs e)
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
                start = DateTimeUtil.StartOfDay(start);
                end = DateTimeUtil.EndOfDay(end);
                //finish day select
                IEnumerable<HistoryNhanVien> li = new List<HistoryNhanVien>();
                var st = txtTim.Text.ToUpper();
                switch (cbbCheDoLoc.SelectedIndex)
                {
                    case 0:
                        li = danhSachLichSu.Where(h => h.NhanVien.MaThe.ToUpper().Contains(st) || h.NhanVien.TenNhanVien.ToUpper().Contains(st)).ToList();
                        break;
                    case 1:
                        li = danhSachLichSu.Where(h => h.NhanVien.MaThe.ToUpper().Contains(st));
                        break;
                    case 2:
                        li = danhSachLichSu.Where(h => h.NhanVien.TenNhanVien.ToUpper().Contains(st));
                        break;
                }

                li = li.Where(h => h.ThoiGian.CompareTo(start) >= 0 && h.ThoiGian.CompareTo(end) <= 0
                    );
                var mode = cbbInOut.SelectedIndex;
                switch (mode) { 
                    case 1:
                        li = li.Where(h => h.IsCheckin = true);
                        break;
                    case 2:
                        li = li.Where(h => h.IsCheckin = false);
                        break;
                }
                updateTable(li.ToList());

            }
            catch {
                //MessageBox.Show("Có lỗi khi loch");
            }
        }

        void loadData()
        {

            var isGym = cbbInOut.SelectedIndex == 0;
           // int mode = cbbInOut.SelectedIndex;
            danhSachLichSu = HistotyNhanVienController.GetList(0);
            
            //updateTable(danhSachLichSu);
        }
        void updateTable(List<HistoryNhanVien> li)
        {
            dataGridView1.DataSource = li;
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnTim_Click(null, null);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var hvh = (HistoryNhanVien)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            if (e.ColumnIndex == 0)
            {
                e.Value = hvh.NhanVien.MaThe;
            }
            if (e.ColumnIndex == 1)
            {
                e.Value = hvh.NhanVien.TenNhanVien;
            }
            if (e.ColumnIndex == 2) {
                e.Value = hvh.IsCheckin ? "Checkin" : "Checkout";
            }
            if (e.ColumnIndex == 4) {
                e.Value = (hvh.IsCheckin) ? DateTimeUtil.timeToString(hvh.Ca.GioBatDau) : DateTimeUtil.timeToString(hvh.Ca.GioKetThuc);
            }
            if (e.ColumnIndex == 5)
            {
                e.Value = DateTimeUtil.timeToString( hvh.ThoiGian.TimeOfDay);
            }
            if (e.ColumnIndex == 7)
            {
               // e.Value = DateTimeUtil.timeToString(hvh.ChenhLech);
                e.Value = hvh.ChenhLech;
            }
        }

        private void cbbTheoThangThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdTheoThang.Checked)
            loc();
        }

        private void rdTheoQuy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTheoQuy.Checked)
                loc();
        }

        private void rdTheoKhoangNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTheoKhoangNgay.Checked)
                loc();
        }

        private void cbbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            loc();
        }
    }
}
