using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class HistoryHoiVienController
    {
        internal static List<HistoryHoiVien> GetList(bool isCheckin, bool isSauna = false)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HistoryHoiVien.Where(d=>d.IsCheckin == isCheckin
                   && d.IsSauna == isSauna );
                
                return nvs.ToList();
            }
        }

        internal static HistoryHoiVien GetByID(DateTime thoiGian)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HistoryHoiVien.FirstOrDefault(n => n.ThoiGian == thoiGian);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(HistoryHoiVien sp)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.HistoryHoiVien.FirstOrDefault(n => n.ThoiGian == sp.ThoiGian);
                    if (n1 == null)
                    {
                        context.HistoryHoiVien.Add(sp);
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
                var pt = context.HistoryHoiVien.FirstOrDefault(p => p.ThoiGian == id);
                if (pt != null)
                {
                    context.HistoryHoiVien.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
