namespace CarQuoteInsurance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Zach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarOwners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        DateOfBirth = c.DateTime(),
                        CarYear = c.Int(),
                        CarMake = c.String(),
                        CarModel = c.String(),
                        DUI = c.Boolean(),
                        CoverageType = c.Boolean(),
                        SpeedingTickets = c.Int(),
                        PaymentPerMonth = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarOwners");
        }
    }
}
