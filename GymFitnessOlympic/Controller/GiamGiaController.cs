using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class GiamGiaController
    {
        internal static List<GiamGia> GetList()
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.GiamGia;
                return nvs.ToList();
            }
        }

        internal static GiamGia GetByID(int maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.GiamGia.FirstOrDefault(n => n.MaGiamGia == maSP);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(GiamGia sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.GiamGia.FirstOrDefault(n => n.MaGiamGia == sp.MaGiamGia);
                    if (n1 == null)
                    {
                        context.GiamGia.Add(sp);
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

        internal static CODE_RESULT_RETURN Update(GiamGia hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.GiamGia.FirstOrDefault(h => h.MaGiamGia  == hv.MaGiamGia);
                if (hvc != null)
                {
                    hvc.NgayCuoi = hv.NgayCuoi;
                    hvc.NgayDau = hv.NgayDau;
                    hvc.PhanTramGiam = hv.PhanTramGiam;
                    hvc.TenGiamGia = hv.TenGiamGia;
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
                var pt = context.GiamGia.FirstOrDefault(p => p.MaGiamGia == id);
                if (pt != null)
                {
                    context.GiamGia.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
