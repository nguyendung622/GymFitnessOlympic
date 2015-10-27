using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public partial class HoiVien
    {
      
        public string MaHoiVien { get; set; }
        public string TenHoiVien { get; set; }
        public string MaVachSauna { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayHetHan { get; set; }
        public PhongTap PhongTap { get; set; }
        public int MaPhongTap { get; set; }
        public string Anh { get; set; }

        public HoiVien()
        {
            MaHoiVien = Guid.NewGuid().ToString();
        }

    }
}
