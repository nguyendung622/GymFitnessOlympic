using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class NhanVien
    {
 
        public int MaNhanVien { get; set; }
        public string MaThe { get; set; }
        public string TenNhanVien { get; set; }
        public bool GioiTinh { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get;set;}
        public Quyen Quyen { get; set; }
        public byte[] Anh { get; set; }
        public PhongTap PhongTap { get; set; }
        public List<PhieuThu> DanhSachPhieuThu { get; set; }
        public List<HoaDon> DanhSachHoaDon { get; set; }
        public List<HistoryNhanVien> LichSu { get; set; }
        public NhanVien() {
            MaThe = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return TenNhanVien;
        }
    }
}
