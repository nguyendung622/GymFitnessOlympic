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
           // Database.SetInitializer<DBContext>(new DropCreateDatabaseIfModelChanges<DBContext>());
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
        public DbSet<CaLamViec> CaLamViec { get; set; }
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
            modelBuilder.Configurations.Add(new CaLamViecMap());
            //---------------------Primary key------------------------------------
            /**
             * 
             * 
             * */
            modelBuilder.Entity<HoiVien>()
        .Property(c => c.MaHoiVien)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ChiTietHoaDon>().HasKey(s => new { s.MaHoaDon, s.MaSanPham });
            modelBuilder.Entity<GiamGia>().HasKey(s => s.MaGiamGia);
            modelBuilder.Entity<GoiTap>().HasKey(s => s.MaGoiTap);
            modelBuilder.Entity<HistoryNhanVien>().HasKey(s => s.ThoiGian);
            modelBuilder.Entity<HistoryHoiVien>().HasKey(s => s.ThoiGian);
            modelBuilder.Entity<HoaDon>().HasKey(s => s.MaHoaDon);
            //modelBuilder.Entity<HoiVien>().HasKey(s => s.MaHoiVien);
            modelBuilder.Entity<KeyValueConfig>().HasKey(s => s.Key);
            modelBuilder.Entity<NhanVien>().HasKey(s => s.MaNhanVien);
            modelBuilder.Entity<PhieuThu>().HasKey(s => s.MaPhieuThu);
            modelBuilder.Entity<PhongTap>().HasKey(s => s.MaPhongTap);
            modelBuilder.Entity<Quyen>().HasKey(s => s.MaQuyen);

            /**
             * 
             * */
            modelBuilder.Entity<HoiVien>().HasRequired(p => p.PhongTap)
                .WithMany(b => b.DanhSachHoiVien)
                .HasForeignKey(p => p.MaPhongTap);

            //a bidirectional one-to-many with a foreign key property (CustomerId) 
            modelBuilder.Entity<HoiVien>().HasRequired(x => x.PhongTap).WithMany(x => x.DanhSachHoiVien)
            .WillCascadeOnDelete();
            //Chi tiet hoa don
            modelBuilder.Entity<ChiTietHoaDon>().HasRequired(x => x.HoaDon).WithMany(x => x.DanhSachChiTiet)
           .WillCascadeOnDelete();
            modelBuilder.Configurations.Add(new KeyValueConfigMap());
            //
            modelBuilder.Entity<ChiTietHoaDon>().HasRequired(x => x.SanPham).WithMany(x => x.ChiTietHoaDon)
           .WillCascadeOnDelete();
            //San pham
            modelBuilder.Entity<SanPham>().HasRequired(x => x.PhongTap).WithMany(x => x.DanhSachSanPham)
        .WillCascadeOnDelete(false);
            //Hoi vien
           // modelBuilder.Entity<HoiVien>().HasRequired(x => x.PhongTap).WithMany(x => x.DanhSachHoiVien)
           //.WillCascadeOnDelete();
            //Nhan vien
            modelBuilder.Entity<NhanVien>().HasRequired(x => x.PhongTap).WithMany(x => x.DanhSachNhanVien)
           .WillCascadeOnDelete();
            //Goi tap
            modelBuilder.Entity<GoiTap>().HasRequired(x => x.PhongTap).WithMany(x => x.DanhSachGoiTap)
           .WillCascadeOnDelete();
            //Phieu thu - hoi vien
            modelBuilder.Entity<PhieuThu>().HasOptional(x => x.HoiVien).WithMany(x => x.DanhSachPhieuThu)
           .WillCascadeOnDelete(false);
            //Phieu thu - nhan vien
            modelBuilder.Entity<PhieuThu>().HasRequired(x => x.NhanVien).WithMany(x => x.DanhSachPhieuThu)
          .WillCascadeOnDelete();
            //Hoa don
            modelBuilder.Entity<HoaDon>().HasRequired(x => x.NhanVien).WithMany(x => x.DanhSachHoaDon)
           .WillCascadeOnDelete();
            //His hoi vien
            modelBuilder.Entity<HistoryHoiVien>().HasRequired(x => x.HoiVien).WithMany(x => x.LichSu)
          .WillCascadeOnDelete();
            //His nhan vien
            modelBuilder.Entity<HistoryNhanVien>().HasRequired(x => x.NhanVien).WithMany(x => x.LichSu)
          .WillCascadeOnDelete();

            System.Diagnostics.Debug.WriteLine("Kết thúc tạo Model");
        }
    }
}