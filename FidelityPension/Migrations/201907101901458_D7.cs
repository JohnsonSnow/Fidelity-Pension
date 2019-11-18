namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LGAs", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LGAs", "Code");
        }
    }
}
