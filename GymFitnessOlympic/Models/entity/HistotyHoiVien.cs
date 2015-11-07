using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class HistoryHoiVien
    {
        public DateTime ThoiGian { get; set; }
        public bool IsSauna {get;set;}
        public HoiVien HoiVien { get; set; }
    }
}
