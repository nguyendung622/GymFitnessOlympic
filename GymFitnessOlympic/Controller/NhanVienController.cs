using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class NhanVienController
    {
        internal static List<NhanVien> GetByPhong(int phongID){
            using (var context = DBContext.GetContext())
            {
                var nvs = context.NhanVien.Include(n=>n.PhongTap).Where(n=>n.PhongTap.MaPhongTap == phongID).ToList();
                return nvs;
            }
        }

        internal static NhanVien GetByID(int manv)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == manv);
                return nv;
            }
        }


        internal static NhanVien Add(NhanVien nv )
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                    return nv;
                }
                catch
                {
                    return null;
                }
            }
        }

        internal static NhanVien Update(NhanVien nv)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var nv1 = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                    if (nv1 != null)
                    {
                        
                    }
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
