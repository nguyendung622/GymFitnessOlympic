using GymFitnessOlympic.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Util
{
    public class Login1
    {
        public static NhanVien TaiKhoanHienTai;
        public static PhongTap PhongTapHienTai;
        public static CaLamViec CaHienTai;

        public static NhanVien GetTaiKhoanHienTai()
        {
            return TaiKhoanHienTai != null ? TaiKhoanHienTai :
             NhanVienController.GetFirst();
        }

        public static PhongTap GetPhongHienTai()
        {
            if (PhongTapHienTai == null) { 
               // PhongTapHienTai = NhanVienController.GetPhong(TaiKhoanHienTai.MaNhanVien);
                PhongTapHienTai = NhanVienController.GetPhong(NhanVienController.GetByID().MaNhanVien);
            }
            return PhongTapHienTai;
        }

    }
}
