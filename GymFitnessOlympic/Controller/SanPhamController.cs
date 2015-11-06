using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

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

        internal static CODE_RESULT_RETURN Update(PhongTap hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.PhongTap.FirstOrDefault(h => h.MaPhongTap  == hv.MaPhongTap);
                if (hvc != null)
                {
                    hvc.DiaChi = hv.DiaChi;
                    hvc.TenPhongTap = hv.TenPhongTap;
                  
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
    }
}
