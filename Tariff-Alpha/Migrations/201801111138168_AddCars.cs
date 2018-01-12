namespace Tariff_Alpha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Colour = c.String(),
                        VIN = c.String(),
                    })
                .PrimaryKey(t => t.CarID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Number = c.String(),
                        Email = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.DriverID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
            DropTable("dbo.Cars");
        }
    }
}
