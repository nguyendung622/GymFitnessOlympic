using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GymFitnessOlympic.Models.Mapping
{
    public class KeyValueConfigMap : EntityTypeConfiguration<KeyValueConfig>
    {
        public KeyValueConfigMap()
        {
            // Khoá chính
            this.HasKey(t => t.Key);

            // Các cột
            this.Property(t => t.Key)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(250);

            // Ánh xạ Property của POCO vào Column của Table
            this.ToTable("AppConfig");
            this.Property(t => t.Key).HasColumnName("_Key");
            this.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
