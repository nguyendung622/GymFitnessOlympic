using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class HoiVienController
    {
        internal static List<HoiVien> GetList(int phongID)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HoiVien.Include(n=>n.PhongTap);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
            }
        }

        internal static NhanVien GetHoiVien(int manv)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == manv);
                return nv;
            }
        }

        internal static CODE_RESULT_RETURN Update(HoiVien hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.HoiVien.FirstOrDefault(h=>h.MaHoiVien == hv.MaHoiVien);
                if (hvc != null)
                {
                    hvc.NgayHetHan = hv.NgayHetHan;
                    hvc.NgaySinh = hv.NgaySinh;
                    hvc.MaVachSauna = hv.MaVachSauna;
                    hvc.TenHoiVien = hv.TenHoiVien;

                    if (hv.PhongTap != null)
                    {
                        var phongMoi = db.PhongTap.FirstOrDefault(p => p.MaPhongTap == hv.PhongTap.MaPhongTap);
                        hvc.PhongTap = phongMoi;
                    }
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Add(HoiVien hv)
        {
            using (var context = DBContext.GetContext())
            {
                var ds = (from e in context.HoiVien
                          where e.MaHoiVien == hv.MaHoiVien
                          select e).SingleOrDefault();
                if (ds != null)
                    return CODE_RESULT_RETURN.MaTrung;
                else
                {
                    context.HoiVien.Add(hv);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
            }
        }
    }
}
