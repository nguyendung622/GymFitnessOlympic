using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class HoaDonMap:EntityTypeConfiguration<HoaDon>
    {
        
            public HoaDonMap()
            {
                // Khoá chính
                this.HasKey(t => t.MaHoaDon);
                //Các cột
                this.Property(t => t.NgayLap).IsRequired();

                this.ToTable("HoaDon");
            }
        
    }
}
