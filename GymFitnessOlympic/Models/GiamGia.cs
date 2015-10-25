using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class GiamGia
    {
   
        public int MaGiamGia { get; set; }
        public string TenGiamGia { get; set; }
        public DateTime NgayDau { get; set; }
        public DateTime NgayCuoi { get; set; }
        public decimal PhanTramGiam { get; set; }
    }
}
