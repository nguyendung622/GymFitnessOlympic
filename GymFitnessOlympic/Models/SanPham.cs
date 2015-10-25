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
        public long Gia { get; set; }
        public PhongTap PhongTap { get; set; }
        //public int MaPhongTap { get; set; }
        
    }
}
