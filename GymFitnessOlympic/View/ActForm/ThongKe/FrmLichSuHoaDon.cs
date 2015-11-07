using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.ActForm.ThongKe
{
    public partial class FrmLichSuHoaDon : UserControl
    {
        NhanVien nhanVienHienTai;
        PhongTap phongHienTai;
        List<HoaDon> allPhieuThu;
        List<ThongKeSanPhamModel> allThongKe;


        public FrmLichSuHoaDon(NhanVien _maNV = null)
        {
            InitializeComponent();
            nhanVienHienTai = _maNV;
            dataGridView1.AutoGenerateColumns = false;
            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoQuyNam.Items.Add(i);
                cbbTheoThangNam.Items.Add(i);

            }
            cbbTheoQuyNam.SelectedIndex = cbbTheoQuyQuy.SelectedIndex = cbbTheoThangNam.SelectedIndex
                = cbbTheoThangThang.SelectedIndex = 0;
            phongHienTai = Login1.GetPhongHienTai();
            cbbPhong.Properties.NullText = "Chọn một phòng";
            DataFiller.fillPhongCombo(cbbPhong);
            cbbPhong.EditValue = phongHienTai.MaPhongTap;

            //loadData();
            loc();
            loadEnable();
        }

        void loadEnable()
        {
            cbbPhong.Enabled = nhanVienHienTai == null;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbbPhong.SelectedItem == null)
            {
                cbbPhong.Focus();
                dxErrorProvider1.SetError(cbbPhong, "Chưa chọn phòng");
                return;
            }
            loc();
        }

        void loc()
        {
            //var maPhong =Convert.ToInt32( cbbPhong.SelectedItem);
            try
            {
                phongHienTai = (PhongTap)cbbPhong.SelectedItem;
            }
            catch { 
            }
            var maPhong = phongHienTai != null ? phongHienTai.MaPhongTap : -1;
            allPhieuThu = HoaDonController.GetList(phongHienTai.MaPhongTap, nhanVienHienTai);
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
                List<HoaDon> li = new List<HoaDon>();


                //li = allPhieuThu.Where(h => h.NgayLap.CompareTo(start) >= 0 && h.NgayLap.CompareTo(end) <= 0).ToList();
                allThongKe = SanPhamController.ThongKeBanRa(start, end,  maPhong, nhanVienHienTai);
                dataGridView1.DataSource = allThongKe;
                lblTongTien.Text = allThongKe.Sum(c => c.TongTien).ToString();
            }
            catch { }
        }
    }

    class ThongKeSanPhamModel {
        public SanPham SanPham { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }
    }
}
