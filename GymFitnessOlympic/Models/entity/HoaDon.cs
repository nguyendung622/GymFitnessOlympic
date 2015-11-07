using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public partial class HoaDon
    {

        public int MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public NhanVien NhanVien { get; set; }
        public List<ChiTietHoaDon> DanhSachChiTiet { get; set; }
        public bool IsNhap { get; set; }
        public HoaDon() {
            DanhSachChiTiet = new List<ChiTietHoaDon>();
            IsNhap = false;
        }
    }
}
