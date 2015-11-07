using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class SanPham
    {
       
        public int MaSanPham { get; set; }
        public String TenSanPham { get; set; }
        public int Gia { get; set; }
        public PhongTap PhongTap { get; set; }
        public List<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public int MaPhongTap { get; set; }

        public override string ToString()
        {
            return TenSanPham;
        }
    }
}
