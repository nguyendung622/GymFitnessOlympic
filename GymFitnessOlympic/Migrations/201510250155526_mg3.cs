namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhongTap", "NhanVien_MaNhanVien", "dbo.NhanVien");
            DropIndex("dbo.PhongTap", new[] { "NhanVien_MaNhanVien" });
            AddColumn("dbo.NhanVien", "PhongTap_MaPhongTap", c => c.Int());
            CreateIndex("dbo.NhanVien", "PhongTap_MaPhongTap");
            AddForeignKey("dbo.NhanVien", "PhongTap_MaPhongTap", "dbo.PhongTap", "MaPhongTap");
            DropColumn("dbo.PhongTap", "NhanVien_MaNhanVien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhongTap", "NhanVien_MaNhanVien", c => c.Int());
            DropForeignKey("dbo.NhanVien", "PhongTap_MaPhongTap", "dbo.PhongTap");
            DropIndex("dbo.NhanVien", new[] { "PhongTap_MaPhongTap" });
            DropColumn("dbo.NhanVien", "PhongTap_MaPhongTap");
            CreateIndex("dbo.PhongTap", "NhanVien_MaNhanVien");
            AddForeignKey("dbo.PhongTap", "NhanVien_MaNhanVien", "dbo.NhanVien", "MaNhanVien");
        }
    }
}
