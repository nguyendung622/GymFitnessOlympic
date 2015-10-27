﻿using GymFitnessOlympic.Models;
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
        internal static List<NhanVien> GetByPhong(int phongID = -1){
            using (var context = DBContext.GetContext())
            {
                var nvs = context.NhanVien.Include(n => n.PhongTap);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
            }
        }

        internal static NhanVien GetByID(int maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == maSP);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(NhanVien nv)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                    if (n1 == null)
                    {
                        context.NhanVien.Add(nv);
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

        internal static CODE_RESULT_RETURN Update(NhanVien hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.NhanVien.FirstOrDefault(h => h.MaNhanVien == hv.MaNhanVien);
                if (hvc != null)
                {
                    hvc.TenNhanVien = hv.TenNhanVien;
                    hvc.UserName = hv.UserName;
                    if (hv.PhongTap != null)
                    {
                        var phongMoi = db.PhongTap.FirstOrDefault(p => p.MaPhongTap == hv.PhongTap.MaPhongTap);
                        hvc.PhongTap = phongMoi;
                    }
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
                var pt = context.NhanVien.FirstOrDefault(p => p.MaNhanVien == id);
                if (pt != null)
                {
                    context.NhanVien.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
