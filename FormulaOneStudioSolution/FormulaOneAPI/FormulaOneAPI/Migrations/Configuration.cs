namespace FormulaOneAPI.Migrations
{
    using FormulaOneAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FormulaOneAPI.Data.FormulaOneAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FormulaOneAPI.Data.FormulaOneAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Drivers.AddOrUpdate(new Driver[] {
                new Driver(){
                    driverId=0,
                    driverRef="sas",
                    //number=4,
                    code="aaa",
                    forename="sasssarello",
                    surname="bello",
                    dob=new DateTime(2000,12,16),
                    nationality="Romania",
                    url="sas.com",
                    PathImgSmall="sasasadsa"
                }
            });
        }
    }
}
