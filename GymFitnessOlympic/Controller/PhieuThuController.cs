using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class PhieuThuController
    {
        internal static List<PhieuThu> GetList(int maPhong, NhanVien nv = null)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.PhieuThu.Include(n => n.HoiVien).Include(n=>n.NhanVien.PhongTap)
                    .Where(p=>p.NhanVien.PhongTap.MaPhongTap == maPhong);
                if (nv != null)
                {
                    nvs = nvs.Where(n => n.NhanVien.MaNhanVien == nv.MaNhanVien);
                }
                return nvs.ToList();
            }
        }

        internal static PhieuThu GetPhieuThu(int manv)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.PhieuThu.FirstOrDefault(n => n.MaPhieuThu == manv);
                return nv;
            }
        }

        internal static CODE_RESULT_RETURN Update(PhieuThu phieuThuMoi)
        {
            using (var db = DBContext.GetContext())
            {
                var phieuThuCu = db.PhieuThu.FirstOrDefault(h => h.MaPhieuThu == phieuThuMoi.MaPhieuThu);
                if (phieuThuCu != null)
                {
                    phieuThuCu.NgayLap = phieuThuMoi.NgayLap;
                    phieuThuCu.SoTien = phieuThuMoi.SoTien;
                    try
                    {
                        var nhanVienMoi = db.NhanVien.FirstOrDefault(n => n.MaNhanVien == phieuThuMoi.NhanVien.MaNhanVien);
                        if (nhanVienMoi != null)
                        {
                            phieuThuCu.NhanVien = nhanVienMoi;
                        }
                    }
                    catch
                    {

                    }
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Add(PhieuThu pt)
        {
            using (var context = DBContext.GetContext())
            {
                var ds = (from e in context.PhieuThu
                          where e.MaPhieuThu == pt.MaPhieuThu
                          select e).SingleOrDefault();
                if (ds != null)
                    return CODE_RESULT_RETURN.MaTrung;
                else
                {
                    var h = context.HoiVien.Find(pt.HoiVien.MaHoiVien);
                    pt.HoiVien = h;
                    var g = context.GoiTap.Find(pt.GoiTap.MaGoiTap);
                    pt.GoiTap = g;
                    pt.NhanVien = context.NhanVien.Find(pt.NhanVien.MaNhanVien);
                    context.PhieuThu.Add(pt);
                    context.SaveChanges();
                    if (pt.GoiTap.Type == 1)
                    {
                       pt.HoiVien.NgayHetHanGYM = pt.HoiVien.NgayHetHanGYM.AddDays(pt.GoiTap.SoThang * 30);
                       pt.HoiVien.GiaHanCuoiGYM = DateTime.Now;
                    }
                    else {
                        pt.HoiVien.NgayHetHanSauNa = pt.HoiVien.NgayHetHanSauNa.AddDays(pt.GoiTap.SoThang * 30);
                        pt.HoiVien.GiaHanCuoiSauna = DateTime.Now;
                    }
                    var r = HoiVienController.updateNgayHetHan(pt.HoiVien);
                    if (r == CODE_RESULT_RETURN.ThanhCong)
                    {
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        

        

        internal static CODE_RESULT_RETURN Delete(int id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt =context.PhieuThu.FirstOrDefault(p => p.MaPhieuThu == id);
                if (pt != null)
                {
                    context.PhieuThu.Remove(pt);
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }

        }
    }
}
