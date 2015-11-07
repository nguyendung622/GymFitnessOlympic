using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    public class HoiVienMap : EntityTypeConfiguration<HoiVien>
    {
        public HoiVienMap()
            {
                // Khoá chính
                this.HasKey(t => t.MaHoiVien);
                //Các cột
                this.Property(t => t.NgaySinh).IsRequired();
                this.Property(t => t.NgayHetHanGYM).IsRequired();
                this.Property(t => t.TenHoiVien).IsRequired().HasMaxLength(50);

                this.ToTable("HoiVien");
            }
    }
}
