using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class CaLamViec
    {
        public int MaCa{get;set;}
        public string TenCa { get; set; }
        public TimeSpan GioBatDau {get;set;}
        public TimeSpan GioKetThuc {get;set;}
        
        public override string ToString()
        {
            return TenCa;
        }
    }
}
