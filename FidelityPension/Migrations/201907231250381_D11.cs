namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FORM_REFNO", c => c.String());
            DropColumn("dbo.Employees", "FORM_RENO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "FORM_RENO", c => c.String());
            DropColumn("dbo.Employees", "FORM_REFNO");
        }
    }
}
