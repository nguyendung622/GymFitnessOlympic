using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class HistotyNhanVienController
    {
        internal static List<HistoryNhanVien> GetList(bool isCheckin)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HistoryNhanVien.Where(d=>d.IsCheckin == isCheckin
                    );
                
                return nvs.ToList();
            }
        }

        internal static HistoryNhanVien GetByID(DateTime thoiGian)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HistoryNhanVien.FirstOrDefault(n => n.ThoiGian == thoiGian);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(HistoryNhanVien sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.HistoryNhanVien.FirstOrDefault(n => n.ThoiGian == sp.ThoiGian);
                    if (n1 == null)
                    {
                        context.HistoryNhanVien.Add(sp);
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

       
        internal static CODE_RESULT_RETURN Delete(DateTime id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.HistoryNhanVien.FirstOrDefault(p => p.ThoiGian == id);
                if (pt != null)
                {
                    context.HistoryNhanVien.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
