namespace Tariff_Alpha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriversCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "CarID_CarID", c => c.Int());
            CreateIndex("dbo.Drivers", "CarID_CarID");
            AddForeignKey("dbo.Drivers", "CarID_CarID", "dbo.Cars", "CarID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drivers", "CarID_CarID", "dbo.Cars");
            DropIndex("dbo.Drivers", new[] { "CarID_CarID" });
            DropColumn("dbo.Drivers", "CarID_CarID");
        }
    }
}
