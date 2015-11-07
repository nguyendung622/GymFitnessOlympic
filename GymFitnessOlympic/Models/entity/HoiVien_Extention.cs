using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
   public  partial class HoiVien
    {
       public string TenPhongTap() {
           return PhongTap.TenPhongTap;
       }

       public int SoNgayTruocSinhNhat {
           get
           {
               return NgaySinh.Date.DayOfYear - DateTime.Now.DayOfYear;
           }
       }

       public override string ToString()
       {
           return TenHoiVien;
       }
    }
}
