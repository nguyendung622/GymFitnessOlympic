using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class PhongTapMap : EntityTypeConfiguration<PhongTap>
    {
        public PhongTapMap()
            {
                // Khoá chính
                this.HasKey(t => t.MaPhongTap);
                //Các cột
                this.Property(t => t.DiaChi).IsRequired();
                this.Property(t => t.TenPhongTap).IsRequired();
                this.ToTable("PhongTap");
            }
    }
}
