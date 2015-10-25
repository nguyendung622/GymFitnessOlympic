using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class GiamGiaMap : EntityTypeConfiguration<GiamGia>
    {
        public GiamGiaMap()
        {
            // Khoá chính
            this.HasKey(t => t.MaGiamGia);
            //Các cột
            this.Property(t => t.NgayDau).IsRequired();
            this.Property(t => t.NgayCuoi).IsRequired();
            this.Property(t => t.TenGiamGia).HasMaxLength(255);

            this.ToTable("GiamGia");
            this.Property(t => t.MaGiamGia).HasColumnName("MaGiamGia");
            this.Property(t => t.TenGiamGia).HasColumnName("TenGiamGia");
            this.Property(t => t.NgayDau).HasColumnName("NgayDau");
            this.Property(t => t.NgayCuoi).HasColumnName("NgayCuoi");


        }
    }
}
