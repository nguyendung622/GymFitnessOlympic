using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Mapping;
using System;
using System.ComponentModel.DataAnnotations.Schema;

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
        //[notMapped]
        public DbSet<AppUser> AppUserDbSet { get; set; }
        //
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<GiamGia> GiamGia { get; set; }
        public DbSet<GoiTap> GoiTap { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoiVien> HoiVien { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhieuThu> PhieuThu { get; set; }
        public DbSet<PhongTap> PhongTap { get; set; }
        public DbSet<Quyen> Quyen { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<HistoryHoiVien> HistoryHoiVien { get; set; }
        public DbSet<HistoryNhanVien> HistoryNhanVien { get; set; }
        //
        public DbSet<KeyValueConfig> KeyValueDbSet { get; set; }
        //

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  modelBuilder.Entity<ChiTietHoaDon>().HasKey(s => new { s.MaHoaDon, s.MaSanPham});
            System.Diagnostics.Debug.WriteLine("Bắt đầu tạo Model");
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new ChiTietHoaDonMap());
            modelBuilder.Configurations.Add(new GiamGiaMap());
            modelBuilder.Configurations.Add(new GoiTapMap());
            modelBuilder.Configurations.Add(new HoaDonMap());
            modelBuilder.Configurations.Add(new HoiVienMap());
            modelBuilder.Configurations.Add(new NhanVienMap());
            modelBuilder.Configurations.Add(new PhieuThuMap());
            modelBuilder.Configurations.Add(new PhongTapMap());
            modelBuilder.Configurations.Add(new QuyenMap());
            modelBuilder.Configurations.Add(new SanPhamMap());
            modelBuilder.Configurations.Add(new HistoryNhanVienMap());
            modelBuilder.Configurations.Add(new HistoryHoiVienMap());
            modelBuilder.Entity<ChiTietHoaDon>().HasKey(s => new { s.MaHoaDon, s.MaSanPham });
            //a bidirectional one-to-many with a foreign key property (CustomerId) 
            modelBuilder.Entity<HoiVien>().HasRequired(x => x.PhongTap).WithMany(x => x.DanhSachHoiVien)
            .HasForeignKey(x => x.MaPhongTap);
            //
           
            modelBuilder.Configurations.Add(new KeyValueConfigMap());

            System.Diagnostics.Debug.WriteLine("Kết thúc tạo Model");
        }
    }
}
