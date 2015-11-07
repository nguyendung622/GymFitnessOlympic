using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Mapping
{
    class CaLamViecMap : EntityTypeConfiguration<CaLamViec>
    {
        public CaLamViecMap()
        {
            // Khoá chính
            this.HasKey(t => t.MaCa);
            //Các cột


        }

        
    }
}
