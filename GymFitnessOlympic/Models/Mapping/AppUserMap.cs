using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GymFitnessOlympic.Models;

namespace GymFitnessOlympic.Models.Mapping
{
	public class AppUserMap : EntityTypeConfiguration<AppUser>
	{
		public AppUserMap()
		{
			// Khoá chính
			this.HasKey(t => t.UserName);

			// Các cột
			this.Property(t => t.UserName)
				.IsRequired()
                .HasMaxLength(50);

			this.Property(t => t.FullName)
				.IsRequired()
                .HasMaxLength(255);

			this.Property(t => t.Password)
				.IsRequired()
                .HasMaxLength(255);

			// Ánh xạ Property của POCO vào Column của Table
			this.ToTable("AppUser");
			this.Property(t => t.UserName).HasColumnName("UserName");
			this.Property(t => t.FullName).HasColumnName("FullName");
			this.Property(t => t.Password).HasColumnName("Password");
			this.Property(t => t.Role).HasColumnName("Role");
			this.Property(t => t.IsActive).HasColumnName("IsActive");
		}
	}
}
