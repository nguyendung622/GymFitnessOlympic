namespace GymFitnessOlympic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiamGia", "PhanTramGiam", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GiamGia", "PhanTramGiam");
        }
    }
}
