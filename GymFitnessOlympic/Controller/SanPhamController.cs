using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GymFitnessOlympic.View.ActForm.ThongKe;
using GymFitnessOlympic.View.ActForm;

namespace GymFitnessOlympic.Controller
{
    class SanPhamController
    {
        internal static List<SanPham> GetList(int phongID = -1)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.SanPham.Include(n => n.PhongTap);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
            }
        }

        internal static SanPham GetByID(int maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.SanPham.FirstOrDefault(n => n.MaSanPham == maSP );
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(SanPham sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.SanPham.FirstOrDefault(n => n.MaSanPham == sp.MaSanPham);
                    if (n1 == null)
                    {
                        sp.PhongTap = context.PhongTap.Find(sp.PhongTap.MaPhongTap);
                        context.SanPham.Add(sp);
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    return CODE_RESULT_RETURN.MaTrung;
                }
                catch
                {
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }

        internal static CODE_RESULT_RETURN Update(SanPham hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.SanPham.FirstOrDefault(h => h.MaSanPham  == hv.MaSanPham);
                if (hvc != null)
                {
                    hv.PhongTap = db.PhongTap.Find(hv.PhongTap.MaPhongTap);
                    hvc.TenSanPham = hv.TenSanPham;
                    hvc.Gia = hv.Gia;
                  
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Delete(int id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.PhongTap.FirstOrDefault(p => p.MaPhongTap == id);
                if (pt != null)
                {
                    context.PhongTap.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static List<ThongKeSanPhamModel> ThongKeBanRa(DateTime start, DateTime end, int maPhong = -1, NhanVien nhanVienHienTai = null)
        {
            List<ThongKeSanPhamModel> li = new List<ThongKeSanPhamModel>();
            using (var db = DBContext.GetContext())
            {
                var hoaDonTrongKhoang = db.HoaDon.Include(h=>h.NhanVien.PhongTap).Where(h=>h.NgayLap >= start && h.NgayLap <=end).SelectMany(h=>h.DanhSachChiTiet);
                if (maPhong != -1) {
                    hoaDonTrongKhoang = hoaDonTrongKhoang.Where(c => c.HoaDon.NhanVien.PhongTap.MaPhongTap == maPhong);
                }
                if (nhanVienHienTai != null) {
                    hoaDonTrongKhoang = hoaDonTrongKhoang.Where(c => c.HoaDon.NhanVien.MaNhanVien == nhanVienHienTai.MaNhanVien);
                }
                var hh = db.SanPham.ToList();
                foreach(var sp in hh){
                    ThongKeSanPhamModel tk = new ThongKeSanPhamModel() { 
                    SanPham = sp                    
                    };

                    tk.SoLuong = hoaDonTrongKhoang.ToList().Where(c=>c.SanPham.MaSanPham == sp.MaSanPham).Sum(c => c.SoLuong);
                    tk.TongTien = hoaDonTrongKhoang.ToList().Where(c => c.SanPham.MaSanPham == sp.MaSanPham).Sum(c => c.SoLuong * c.Gia);
                    if (tk.SoLuong > 0)
                    {
                        li.Add(tk);
                    }
                }
                return li;
            }
        }

        internal static List<GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel> ThongKeSoLuong()
        {
            List<GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel> li = new List<GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel>();
            
            using (var db = DBContext.GetContext())
            {
                var hh = db.SanPham.ToList();
                var allChiTiet = db.ChiTietHoaDon.Include(c => c.HoaDon).Select(c => c.SanPham);
                foreach (var sp in hh) {
                    GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel model = new GymFitnessOlympic.View.ActForm.FrmKiemKho.ThongKeSoLuongModel();
                    model.SanPham = sp;
                    model.SoBan = db.ChiTietHoaDon.Where(c => !c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong);
                    model.TienBan = db.ChiTietHoaDon.Where(c => !c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong * c.Gia);
                    model.SoNhap = db.ChiTietHoaDon.Where(c => c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong);
                    model.TienNhap = db.ChiTietHoaDon.Where(c => c.HoaDon.IsNhap && c.SanPham.MaSanPham == sp.MaSanPham).ToList().Sum(c => c.SoLuong * c.Gia);
                    li.Add(model);
                }
                return li;
            }
        }
    }
}
