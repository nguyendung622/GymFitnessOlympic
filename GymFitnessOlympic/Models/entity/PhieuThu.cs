using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class PhieuThu
    {
 
        public int MaPhieuThu { get; set; }
        public DateTime NgayLap { get; set; }
        public int SoTien { get; set; }
        public NhanVien NhanVien { get; set; }
        public HoiVien HoiVien { get; set; }
        public GoiTap GoiTap { get; set; }
        public string LyDo { get; set; }
    }
}
