using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Models
{
    public partial class HoaDon
    {
        public int TongTien
        {
            get
            {
                try
                {
                    return DanhSachChiTiet.Sum(c => c.SoLuong * c.Gia);
                }
                catch {
                    return 0;
                }                
            }
        }
    }
}
