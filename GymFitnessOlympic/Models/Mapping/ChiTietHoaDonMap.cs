using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    
    class ChiTietHoaDonMap : EntityTypeConfiguration<ChiTietHoaDon>
    {
       
        public ChiTietHoaDonMap()
        {
            // Khoá chính
            //HasKey(u => u.MaHoaDon);
            //HasKey(u => u.MaSanPham);

            // Các cột
            this.Property(t => t.SoLuong)
                .IsRequired();

            this.Property(t => t.Gia)
                .IsRequired()                ;
            // Ánh xạ Property của POCO vào Column của Table
            this.ToTable("ChiTietHoaDon");
            this.Property(t => t.Gia).HasColumnName("Gia");
            this.Property(t => t.SoLuong).HasColumnName("SoLuong");
            this.Property(t => t.MaHoaDon).HasColumnName("MaHoaDon");
            this.Property(t => t.MaSanPham).HasColumnName("MaSanPham");
        }
    }
}
