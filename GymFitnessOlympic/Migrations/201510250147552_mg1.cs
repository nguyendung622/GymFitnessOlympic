namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUser",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50),
                        FullName = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Role = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.ChiTietHoaDon",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false),
                        MaSanPham = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaHoaDon, t.MaSanPham })
                .ForeignKey("dbo.HoaDon", t => t.MaHoaDon, cascadeDelete: true)
                .ForeignKey("dbo.SanPham", t => t.MaSanPham, cascadeDelete: true)
                .Index(t => t.MaHoaDon)
                .Index(t => t.MaSanPham);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDon);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(nullable: false),
                        Gia = c.Long(nullable: false),
                        PhongTap_MaPhongTap = c.Int(),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.PhongTap", t => t.PhongTap_MaPhongTap)
                .Index(t => t.PhongTap_MaPhongTap);
            
            CreateTable(
                "dbo.PhongTap",
                c => new
                    {
                        MaPhongTap = c.Int(nullable: false, identity: true),
                        TenPhongTap = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        NhanVien_MaNhanVien = c.Int(),
                    })
                .PrimaryKey(t => t.MaPhongTap)
                .ForeignKey("dbo.NhanVien", t => t.NhanVien_MaNhanVien)
                .Index(t => t.NhanVien_MaNhanVien);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false, identity: true),
                        TenNhanVien = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 30),
                        Quyen_MaQuyen = c.Int(),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.Quyen", t => t.Quyen_MaQuyen)
                .Index(t => t.Quyen_MaQuyen);
            
            CreateTable(
                "dbo.Quyen",
                c => new
                    {
                        MaQuyen = c.Int(nullable: false, identity: true),
                        TenQuyen = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaQuyen);
            
            CreateTable(
                "dbo.GiamGia",
                c => new
                    {
                        MaGiamGia = c.Int(nullable: false, identity: true),
                        TenGiamGia = c.String(maxLength: 255),
                        NgayDau = c.DateTime(nullable: false),
                        NgayCuoi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaGiamGia);
            
            CreateTable(
                "dbo.GoiTap",
                c => new
                    {
                        MaGoiTap = c.Int(nullable: false, identity: true),
                        TenGoiTap = c.String(),
                        Gia = c.Int(nullable: false),
                        SoThang = c.Int(nullable: false),
                        PhongTap_MaPhongTap = c.Int(),
                    })
                .PrimaryKey(t => t.MaGoiTap)
                .ForeignKey("dbo.PhongTap", t => t.PhongTap_MaPhongTap)
                .Index(t => t.PhongTap_MaPhongTap);
            
            CreateTable(
                "dbo.HistoryHoiVien",
                c => new
                    {
                        ThoiGian = c.DateTime(nullable: false),
                        IsCheckin = c.Boolean(nullable: false),
                        HoiVien_MaHoiVien = c.Int(),
                    })
                .PrimaryKey(t => t.ThoiGian)
                .ForeignKey("dbo.HoiVien", t => t.HoiVien_MaHoiVien)
                .Index(t => t.HoiVien_MaHoiVien);
            
            CreateTable(
                "dbo.HoiVien",
                c => new
                    {
                        MaHoiVien = c.Int(nullable: false, identity: true),
                        TenHoiVien = c.String(nullable: false, maxLength: 50),
                        NgayDangKy = c.DateTime(nullable: false),
                        NgayHetHan = c.DateTime(nullable: false),
                        Phong_MaPhongTap = c.Int(),
                    })
                .PrimaryKey(t => t.MaHoiVien)
                .ForeignKey("dbo.PhongTap", t => t.Phong_MaPhongTap)
                .Index(t => t.Phong_MaPhongTap);
            
            CreateTable(
                "dbo.HistoryNhanVien",
                c => new
                    {
                        ThoiGian = c.DateTime(nullable: false),
                        IsCheckin = c.Boolean(nullable: false),
                        NhanVien_MaNhanVien = c.Int(),
                    })
                .PrimaryKey(t => t.ThoiGian)
                .ForeignKey("dbo.NhanVien", t => t.NhanVien_MaNhanVien)
                .Index(t => t.NhanVien_MaNhanVien);
            
            CreateTable(
                "dbo.AppConfig",
                c => new
                    {
                        _Key = c.String(nullable: false, maxLength: 50),
                        Value = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t._Key);
            
            CreateTable(
                "dbo.PhieuThu",
                c => new
                    {
                        MaPhieuThu = c.Int(nullable: false, identity: true),
                        NgayLap = c.DateTime(nullable: false),
                        SoTien = c.Int(nullable: false),
                        HoiVien_MaHoiVien = c.Int(),
                    })
                .PrimaryKey(t => t.MaPhieuThu)
                .ForeignKey("dbo.HoiVien", t => t.HoiVien_MaHoiVien)
                .Index(t => t.HoiVien_MaHoiVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuThu", "HoiVien_MaHoiVien", "dbo.HoiVien");
            DropForeignKey("dbo.HistoryNhanVien", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.HistoryHoiVien", "HoiVien_MaHoiVien", "dbo.HoiVien");
            DropForeignKey("dbo.HoiVien", "Phong_MaPhongTap", "dbo.PhongTap");
            DropForeignKey("dbo.GoiTap", "PhongTap_MaPhongTap", "dbo.PhongTap");
            DropForeignKey("dbo.ChiTietHoaDon", "MaSanPham", "dbo.SanPham");
            DropForeignKey("dbo.SanPham", "PhongTap_MaPhongTap", "dbo.PhongTap");
            DropForeignKey("dbo.PhongTap", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.NhanVien", "Quyen_MaQuyen", "dbo.Quyen");
            DropForeignKey("dbo.ChiTietHoaDon", "MaHoaDon", "dbo.HoaDon");
            DropIndex("dbo.PhieuThu", new[] { "HoiVien_MaHoiVien" });
            DropIndex("dbo.HistoryNhanVien", new[] { "NhanVien_MaNhanVien" });
            DropIndex("dbo.HoiVien", new[] { "Phong_MaPhongTap" });
            DropIndex("dbo.HistoryHoiVien", new[] { "HoiVien_MaHoiVien" });
            DropIndex("dbo.GoiTap", new[] { "PhongTap_MaPhongTap" });
            DropIndex("dbo.NhanVien", new[] { "Quyen_MaQuyen" });
            DropIndex("dbo.PhongTap", new[] { "NhanVien_MaNhanVien" });
            DropIndex("dbo.SanPham", new[] { "PhongTap_MaPhongTap" });
            DropIndex("dbo.ChiTietHoaDon", new[] { "MaSanPham" });
            DropIndex("dbo.ChiTietHoaDon", new[] { "MaHoaDon" });
            DropTable("dbo.PhieuThu");
            DropTable("dbo.AppConfig");
            DropTable("dbo.HistoryNhanVien");
            DropTable("dbo.HoiVien");
            DropTable("dbo.HistoryHoiVien");
            DropTable("dbo.GoiTap");
            DropTable("dbo.GiamGia");
            DropTable("dbo.Quyen");
            DropTable("dbo.NhanVien");
            DropTable("dbo.PhongTap");
            DropTable("dbo.SanPham");
            DropTable("dbo.HoaDon");
            DropTable("dbo.ChiTietHoaDon");
            DropTable("dbo.AppUser");
        }
    }
}
