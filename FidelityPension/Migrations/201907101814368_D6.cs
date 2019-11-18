namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Code", c => c.String());
            AddColumn("dbo.Genders", "Code", c => c.String());
            AddColumn("dbo.States", "Code", c => c.String());
            AddColumn("dbo.Relationships", "Code", c => c.String());
            AddColumn("dbo.Titles", "Code", c => c.String());
            AddColumn("dbo.MaritalStatus", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MaritalStatus", "Code");
            DropColumn("dbo.Titles", "Code");
            DropColumn("dbo.Relationships", "Code");
            DropColumn("dbo.States", "Code");
            DropColumn("dbo.Genders", "Code");
            DropColumn("dbo.Countries", "Code");
        }
    }
}
