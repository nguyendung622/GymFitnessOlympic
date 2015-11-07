using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Controller
{
    class CaLamViecController
    {
        public static List<CaLamViec> GetList() {
            using (var db = DBContext.GetContext())
            {
                return db.CaLamViec.ToList();
            }
        }

        public static CaLamViec Get(int maCa)
        {
            using (var db = DBContext.GetContext())
            {
                return db.CaLamViec.Find(maCa);
            }
        }

        public static CODE_RESULT_RETURN Update(CaLamViec c){
            using (var db = DBContext.GetContext()) {
                var trung = db.CaLamViec.FirstOrDefault(ca => (ca.GioBatDau > c.GioBatDau && ca.GioBatDau < c.GioKetThuc)
                    ||
                    (ca.GioKetThuc > c.GioBatDau && ca.GioKetThuc < c.GioKetThuc));
                if (trung != null)
                    return CODE_RESULT_RETURN.MaTrung;
                var c1 = db.CaLamViec.Find(c.MaCa);
                if (c1 != null) {
                    c1.GioBatDau = c.GioBatDau;
                    c1.GioKetThuc = c.GioKetThuc;
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
