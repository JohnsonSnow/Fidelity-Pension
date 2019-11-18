namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "NOK_DOB", c => c.DateTime());
            AddColumn("dbo.Employees", "BENEFICIARY_DOB", c => c.DateTime());
            AddColumn("dbo.Employees", "FORM_RENO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "FORM_RENO");
            DropColumn("dbo.Employees", "BENEFICIARY_DOB");
            DropColumn("dbo.Employees", "NOK_DOB");
        }
    }
}
