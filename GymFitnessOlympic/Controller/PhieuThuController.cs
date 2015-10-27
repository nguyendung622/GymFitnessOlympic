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
        internal static List<PhieuThu> GetList(string maHoiVien)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.PhieuThu.Include(n => n.HoiVien);
                if (maHoiVien != null)
                {
                    nvs = nvs.Where(n => n.HoiVien.MaHoiVien == maHoiVien);
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

        internal static CODE_RESULT_RETURN Update(PhieuThu hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.PhieuThu.FirstOrDefault(h => h.MaPhieuThu == hv.MaPhieuThu);
                if (hvc != null)
                {
                    hvc.NgayLap = hv.NgayLap;
                    hvc.SoTien = hv.SoTien;
                    try
                    {
                        var nhanVienMoi = db.NhanVien.FirstOrDefault(n => n.MaNhanVien == hv.NhanVien.MaNhanVien);
                        if (nhanVienMoi != null)
                        {
                            hvc.NhanVien = nhanVienMoi;
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

        internal static CODE_RESULT_RETURN Add(PhieuThu hv)
        {
            using (var context = DBContext.GetContext())
            {
                var ds = (from e in context.PhieuThu
                          where e.MaPhieuThu == hv.MaPhieuThu
                          select e).SingleOrDefault();
                if (ds != null)
                    return CODE_RESULT_RETURN.MaTrung;
                else
                {
                    context.PhieuThu.Add(hv);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
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
