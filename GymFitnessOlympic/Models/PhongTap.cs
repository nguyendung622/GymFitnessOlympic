using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class PhongTap
    {

        public int MaPhongTap{get;set;}
        public String TenPhongTap { get; set; }
        public String DiaChi { get; set; }
        public List<HoiVien> DanhSachHoiVien { get; set; }
        public  List<NhanVien> DanhSachNhanVien { get; set; }
        List<SanPham> DanhSachSanPham { get; set; }
        List<GoiTap> DanhSachGoiTap { get; set; }
    }
}
