using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class HoiVienController
    {
        internal static List<HoiVien> GetByPhong(int phongID){
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HoiVien.Include(n=>n.PhongTap);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
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
    }
}
