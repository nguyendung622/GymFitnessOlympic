using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class HistoryNhanVien
    {
        public DateTime ThoiGian { get; set; }
        public bool IsCheckin { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
