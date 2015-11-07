using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;

namespace GymFitnessOlympic.View.ActForm
{
    public partial class FrmKiemKho : DevExpress.XtraEditors.XtraUserControl
    {
        PhongTap phongHienTai;

        public FrmKiemKho()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            loc();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            loc();
        }

        void loc()
        {
            try
            {
                phongHienTai = (PhongTap)cbbPhong.SelectedItem;
            }
            catch
            {
            }
            var maPhong = phongHienTai != null ? phongHienTai.MaPhongTap : -1;
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
                List<ThongKeSoLuongModel> tks = SanPhamController.ThongKeSoLuong();
                dataGridView1.DataSource = tks;
            }
            catch { }


        }

      public  class ThongKeSoLuongModel
        {
            public SanPham SanPham { get; set; }
            public int SoBan { get; set; }
            public int TienBan { get; set; }
            public int SoNhap { get; set; }
            public int TienNhap { get; set; }
            public int Ton
            {
                get
                {
                    return SoNhap - SoBan;
                }
            }
        }
    }
}
