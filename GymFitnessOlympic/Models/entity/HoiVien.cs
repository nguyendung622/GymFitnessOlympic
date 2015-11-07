using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public partial class HoiVien
    {
        public int MaHoiVien { get; set; }
        public string MaGYM { get; set; }
        public string TenHoiVien { get; set; }
        //public string MaSauna { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgayHetHanGYM { get; set; }
        public DateTime NgayHetHanSauNa { get; set; }
        public DateTime GiaHanCuoiGYM { get; set; }
        public DateTime GiaHanCuoiSauna { get; set; }
        public PhongTap PhongTap { get; set; }
       public int MaPhongTap { get; set; }
        public byte[] Anh { get; set; }
        public List<PhieuThu> DanhSachPhieuThu { get; set; }
        public List<HistoryHoiVien> LichSu { get; set; }
        public HoiVien()
        {
            MaGYM = Guid.NewGuid().ToString();
            NgayHetHanGYM = NgayHetHanSauNa = GiaHanCuoiGYM = GiaHanCuoiSauna = DateTime.Now;
        }

    }
}
