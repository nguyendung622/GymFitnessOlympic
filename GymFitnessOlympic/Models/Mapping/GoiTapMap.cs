using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class GoiTapMap : EntityTypeConfiguration<GoiTap>
    {
        public GoiTapMap()
        {
            // Khoá chính
            this.HasKey(t => t.MaGoiTap);
            //Các cột
            this.Property(t => t.Gia).IsRequired();
            this.Property(t => t.SoThang).IsRequired();

            this.ToTable("GoiTap");
            this.Property(t => t.MaGoiTap).HasColumnName("MaGoiTap");
            this.Property(t => t.Gia).HasColumnName("Gia");
            this.Property(t => t.TenGoiTap).HasColumnName("TenGoiTap");
            this.Property(t => t.SoThang).HasColumnName("SoThang");
        }
    }
}
