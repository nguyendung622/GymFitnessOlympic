using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class HistoryNhanVien
    {
        public DateTime ThoiGian { get; set; }
        public bool IsCheckin { get; set; }
        public NhanVien NhanVien { get; set; }
        public CaLamViec Ca { get; set; }

        [NotMapped]
        public int ChenhLech
        {
            get
            {
                var minThoiGian = ThoiGian.Hour * 60 + ThoiGian.Minute;
                var minBatDau = Ca.GioBatDau.Hours * 60 + Ca.GioBatDau.Minutes;
                var minKetThuc = Ca.GioKetThuc.Hours * 60 + Ca.GioKetThuc.Minutes;

                if (IsCheckin) {
                    return minBatDau - minThoiGian;
                }
                return minKetThuc - minThoiGian;
            }
        }
        [NotMapped]
        public String DanhGia
        {
            get
            {
                
                return ChenhLech > 0 ? "Sớm" : "Trễ";
                
            }
        }


    }
}
