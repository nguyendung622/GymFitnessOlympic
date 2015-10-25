namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDon", "NhanVien_MaNhanVien", c => c.Int());
            AddColumn("dbo.PhieuThu", "NhanVien_MaNhanVien", c => c.Int());
            CreateIndex("dbo.HoaDon", "NhanVien_MaNhanVien");
            CreateIndex("dbo.PhieuThu", "NhanVien_MaNhanVien");
            AddForeignKey("dbo.HoaDon", "NhanVien_MaNhanVien", "dbo.NhanVien", "MaNhanVien");
            AddForeignKey("dbo.PhieuThu", "NhanVien_MaNhanVien", "dbo.NhanVien", "MaNhanVien");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuThu", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.HoaDon", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropIndex("dbo.PhieuThu", new[] { "NhanVien_MaNhanVien" });
            DropIndex("dbo.HoaDon", new[] { "NhanVien_MaNhanVien" });
            DropColumn("dbo.PhieuThu", "NhanVien_MaNhanVien");
            DropColumn("dbo.HoaDon", "NhanVien_MaNhanVien");
        }
    }
}
