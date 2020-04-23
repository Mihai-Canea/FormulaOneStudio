namespace FormulaOneAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        driverId = c.Int(nullable: false, identity: true),
                        driverRef = c.String(),
                        number = c.Int(nullable: false),
                        code = c.String(),
                        forename = c.String(nullable: false),
                        surname = c.String(),
                        dob = c.DateTime(nullable: false),
                        nationality = c.String(),
                        url = c.String(),
                        PathImgSmall = c.String(),
                    })
                .PrimaryKey(t => t.driverId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
        }
    }
}
