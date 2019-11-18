namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iPensionTest_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Residential_Building_No", c => c.String());
            AddColumn("dbo.Employees", "Correspondence_Building_No", c => c.String());
            AddColumn("dbo.Employees", "NOK_Building_No", c => c.String());
            AddColumn("dbo.Employees", "BENEFICIARY_Building_No", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
