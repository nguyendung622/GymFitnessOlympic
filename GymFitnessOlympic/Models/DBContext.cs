using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Mapping;

namespace QldtSdh.DAL.Models
{
    public partial class DBContext : DbContext
    {
        static DBContext()
        {
            Database.SetInitializer<DBContext>(new DropCreateDatabaseIfModelChanges<DBContext>());
        }

        public DBContext()
            : base("Name=DBContext")
        {
        }

        public DBContext(string connectionString)
            : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<AppUser> AppUserDbSet { get; set; }
        public DbSet<KeyValueConfig> KeyValueDbSet { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            System.Diagnostics.Debug.WriteLine("Bắt đầu tạo Model");
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new KeyValueConfigMap());
            System.Diagnostics.Debug.WriteLine("Kết thúc tạo Model");
        }
    }
}
