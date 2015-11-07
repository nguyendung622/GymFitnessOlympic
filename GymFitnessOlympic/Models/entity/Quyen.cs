using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public partial class Quyen
    {
     
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }

        public List<NhanVien> DanhSachNhanVien { get; set; }
    }
}
