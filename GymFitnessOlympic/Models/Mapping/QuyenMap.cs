using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class QuyenMap : EntityTypeConfiguration<Quyen>
    {
        public QuyenMap()
            {
                // Khoá chính
                this.HasKey(t => t.MaQuyen);
                //Các cột
                this.Property(t => t.TenQuyen).IsRequired();

                // Ánh xạ Property của POCO vào Column của Table
                this.ToTable("Quyen");
                this.Property(t => t.MaQuyen).HasColumnName("MaQuyen");
                this.Property(t => t.TenQuyen).HasColumnName("TenQuyen");
                this.ToTable("Quyen");
                
            }
    }
}
