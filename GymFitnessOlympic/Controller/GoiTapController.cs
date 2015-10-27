using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class GoiTapController
    {
        internal static List<GoiTap> GetList(int type = 1, int phongID = -1)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.GoiTap.Include(n => n.PhongTap).Where(g=>g.Type == type);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
            }
        }

        internal static GoiTap GetByID(int maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.GoiTap.FirstOrDefault(n => n.MaGoiTap == maSP);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(GoiTap sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.GoiTap.FirstOrDefault(n => n.MaGoiTap == sp.MaGoiTap);
                    if (n1 == null)
                    {
                        context.GoiTap.Add(sp);
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

        internal static CODE_RESULT_RETURN Update(GoiTap hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.GoiTap.FirstOrDefault(h => h.MaGoiTap  == hv.MaGoiTap);
                if (hvc != null)
                {
                    hvc.SoThang = hv.SoThang;
                    hvc.TenGoiTap = hv.TenGoiTap;
                    hvc.Gia = hv.Gia;
                    hvc.Type = hv.Type;
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
                var pt = context.GoiTap.FirstOrDefault(p => p.MaGoiTap == id);
                if (pt != null)
                {
                    context.GoiTap.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
