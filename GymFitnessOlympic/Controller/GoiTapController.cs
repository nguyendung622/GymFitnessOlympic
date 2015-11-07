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
            using (var db = DBContext.GetContext())
            {
                try
                {
                    var n1 = db.GoiTap.FirstOrDefault(n => n.MaGoiTap == sp.MaGoiTap);
                    if (n1 == null)
                    {
                        sp.PhongTap = db.PhongTap.Find(sp.PhongTap.MaPhongTap);
                        db.GoiTap.Add(sp);
                        db.SaveChanges();
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
                var goiCU = db.GoiTap.FirstOrDefault(h => h.MaGoiTap  == hv.MaGoiTap);
                if (goiCU != null)
                {
                    goiCU.SoThang = hv.SoThang;
                    goiCU.TenGoiTap = hv.TenGoiTap;
                    goiCU.Gia = hv.Gia;
                    goiCU.Type = hv.Type;
                    goiCU.PhongTap = db.PhongTap.Find(hv.PhongTap.MaPhongTap);
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
