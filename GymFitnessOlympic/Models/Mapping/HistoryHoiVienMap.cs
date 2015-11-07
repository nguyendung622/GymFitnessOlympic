using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GymFitnessOlympic.Models;

namespace GymFitnessOlympic.Models.Mapping
{
	public class HistoryHoiVienMap : EntityTypeConfiguration<HistoryHoiVien>
	{
        public HistoryHoiVienMap()
		{
			// Khoá chính
			this.HasKey(t => t.ThoiGian);

			

			// Ánh xạ Property của POCO vào Column của Table
			this.ToTable("HistoryHoiVien");
			this.Property(t => t.ThoiGian).HasColumnName("ThoiGian");
		
		}
	}
}
