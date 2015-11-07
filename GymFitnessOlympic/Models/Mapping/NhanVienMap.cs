using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    public class NhanVienMap : EntityTypeConfiguration<NhanVien>
    {
        public NhanVienMap()
            {
                // Khoá chính
                this.HasKey(t => t.MaNhanVien);
                //Các cột
                this.Property(t => t.UserName).IsRequired().HasMaxLength(50);
                this.Property(t => t.Password).IsRequired();
                this.Property(t => t.TenNhanVien).IsRequired().HasMaxLength(50);

                this.ToTable("NhanVien");
            }
    }
}
