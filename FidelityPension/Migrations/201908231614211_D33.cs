namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D33 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "consentFrom_byte", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "consentFrom_byte");
        }
    }
}
