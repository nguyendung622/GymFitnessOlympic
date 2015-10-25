using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class PhieuThuMap : EntityTypeConfiguration<PhieuThu>
    {
        public PhieuThuMap()
            {
                // Khoá chính
                this.HasKey(t => t.MaPhieuThu);
                //Các cột
                this.Property(t => t.NgayLap).IsRequired();
                this.Property(t => t.SoTien).IsRequired();
                this.ToTable("PhieuThu");
            }
    }
}
