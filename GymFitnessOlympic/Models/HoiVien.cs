using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class HoiVien
    {
      
        public int MaHoiVien { get; set; }
        public string TenHoiVien { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime NgayHetHan { get; set; }
        public PhongTap PhongTap { get; set; }
        //public int MaPhongTap { get; set; }

    }
}
