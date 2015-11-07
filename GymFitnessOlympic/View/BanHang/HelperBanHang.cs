using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanHongPhat;
using System.Data.Entity;
using System.Data;
using System.Data.Linq;
using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;

namespace NhaHang.Code.Helper.BanHang
{
    class HelperBanHang
    {
       

        //public static void loadComboBanTheoTrangThai(ComboBox cbbNhom, bool isTrong)
        //{
        //    cbbNhom.DataSource = LoadBanTheoTrangThai(isTrong);
        //    cbbNhom.DisplayMember = "MaBan";
        //    cbbNhom.ValueMember = "MaBan";
        //}

        //public static List<Ban> LoadBanTheoTrangThai(bool isTrong) {
        //    using (var db = new TanHongPhatDataContext()) {
        //        var bs = db.Ban.Where(b=>b.Trong == isTrong).ToList();
        //        return bs;
        //    }
        //}

        internal static int themVaoPhieuNhap(FrmBanHang f, SanPham h)
        {
            var li = f.hoaDon.DanhSachChiTiet;
            var c1 = li.FirstOrDefault(c => c.MaSanPham.ToString() == h.MaSanPham.ToString());
            if (c1 == null)
            {
                int soLuong = Convert.ToInt32(f.spnSoLuong.Value);
                int donGia = h.Gia;
                ChiTietHoaDon c = new ChiTietHoaDon()
                {
                    SanPham = h,
                    MaSanPham = h.MaSanPham,
                    Gia = donGia,
                    SoLuong = soLuong
                };
                f.hoaDon.DanhSachChiTiet.Add(c);
                loadGridHoaDon(f);
                return 1;
            }

            return 0;
        }

        private static void loadGridHoaDon(FrmBanHang f)
        {
            //var pn = f.hoaDon;
            //f.lvHangNhap.Items.Clear();
            //foreach (ChiTietHoaDon c in pn.ChiTietHoaDon)
            //{
            //    string[] s = { c.MaHang.ToString(), c.HangBan.Hang.TenHang, TienIch.formatThousand(c.SoLuong), TienIch.formatThousand(c.DonGia), TienIch.formatThousand(c.SoLuong * c.DonGia) };
            //    ListViewItem i = new ListViewItem(s);
            //    f.lvHangNhap.Items.Add(i);
            //}
        }

        internal static void tangSoLuong(HoaDon hoaDon, SanPham h, int p)
        {
            var c = hoaDon.DanhSachChiTiet.FirstOrDefault(c1 => c1.MaSanPham == h.MaSanPham);
            c.SoLuong += p;
        }

      

        internal static void save(HoaDon hoaDon, NhanVien nhanVien = null)
        {
            using (var db = DBContext.GetContext ())
            {
                var old = db.HoaDon.FirstOrDefault(b => b.MaHoaDon == hoaDon.MaHoaDon);
                if (old == null)
                {
                    //hoaDon.ThoiGianTao = DateTime.Now;
                    hoaDon.NhanVien = nhanVien;
                    var banC = db.NhanVien.Find(hoaDon.NhanVien.MaNhanVien);
                    hoaDon.NhanVien = banC;
                    
                    foreach (var c in hoaDon.DanhSachChiTiet)
                    {
                        c.SanPham = db.SanPham.Find(c.MaSanPham);
                        c.HoaDon = hoaDon;
                    }
                    db.HoaDon.Add(hoaDon);

                }
                else {
                    old.DanhSachChiTiet.Clear();
                    foreach (var c in hoaDon.DanhSachChiTiet)
                    {
                        old.DanhSachChiTiet.Add(new ChiTietHoaDon() {
                            MaSanPham = c.SanPham.MaSanPham,
                            SoLuong= c.SoLuong,
                            Gia= c.Gia
                        });
                    }
                }
                db.SaveChanges();
            }
        }


        

  

        internal static void taoHoaDonTamThoi(HoaDon hoaDon, NhanVien banHienTai, string message)
        {
            save(hoaDon, banHienTai);
            MessageBox.Show(message);
        }

       

       
    }
}
