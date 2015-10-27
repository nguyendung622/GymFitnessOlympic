using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class QuyenController
    {
        internal static List<Quyen> GetList()
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.Quyen;
                return nvs.ToList();
            }
        }

        internal static Quyen GetByID(int maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.Quyen.FirstOrDefault(n => n.MaQuyen == maSP);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(Quyen sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.Quyen.FirstOrDefault(n => n.MaQuyen == sp.MaQuyen);
                    if (n1 == null)
                    {
                        context.Quyen.Add(sp);
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

        internal static CODE_RESULT_RETURN Update(Quyen hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.Quyen.FirstOrDefault(h => h.MaQuyen  == hv.MaQuyen);
                if (hvc != null)
                {
                    hvc.TenQuyen = hv.TenQuyen;
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
                var pt = context.Quyen.FirstOrDefault(p => p.MaQuyen == id);
                if (pt != null)
                {
                    context.Quyen.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
