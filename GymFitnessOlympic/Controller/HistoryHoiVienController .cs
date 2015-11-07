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
        internal static List<HistoryHoiVien> GetList(int phongID = -1 , bool isSauna = false)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HistoryHoiVien.Include(d=>d.HoiVien.PhongTap).Where(d=> d.IsSauna == isSauna );
                if (phongID != -1) {
                    nvs = nvs.Where(d=>d.HoiVien.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
            }
        }

        

        public DateTime GetExpireDay(string code, bool isSauna) {
            using (var db = DBContext.GetContext()) {
                var h =  db.HoiVien.FirstOrDefault(p => p.MaGYM == code);
                if (!isSauna){
                    return h.NgayHetHanGYM;
                }
                return h.NgayHetHanSauNa;
                    
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
                        var hv = context.HoiVien.Find(sp.HoiVien.MaHoiVien);
                        sp.HoiVien = hv;
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
