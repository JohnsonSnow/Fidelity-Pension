namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "ApplicationUserId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "ApplicationUserId", c => c.Int(nullable: false));
        }
    }
}
