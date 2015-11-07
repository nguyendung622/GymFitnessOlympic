using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class GoiTap
    {
        public static  int GOITAP = 1;
         public static  int SAUNA = 2;

        public int MaGoiTap { get; set; }
        public PhongTap PhongTap { get; set; }
        public string TenGoiTap { get; set; }
        public int Gia { get; set; }
        public int SoThang { get; set; }
        public int Type { get;set; }
        public List<PhieuThu> DanhSachPhieuThu { get; set; }
        
        public GoiTap()
        {
            Type = GOITAP;
        }

        public override string ToString()
        {
            return TenGoiTap;
        }
    }
}
