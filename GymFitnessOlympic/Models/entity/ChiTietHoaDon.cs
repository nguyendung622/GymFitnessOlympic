using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
     
    public class ChiTietHoaDon
    {
       //[Key, Column(Order = 0)]
        public int MaHoaDon { get; set; }
       //[Key, Column(Order = 1)]
        public int MaSanPham { get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
      
        [NotMapped]
        public int ThanhTien
        {
            get
            {
                return SoLuong * Gia;
            }

        }
    }
}
