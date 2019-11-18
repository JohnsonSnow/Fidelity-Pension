namespace FidelityPension.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class D88 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "passport_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "NIN_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "Intl_Passport_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "Photo_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "Signature_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "BirthCertificate_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "DriversLicense_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "PermanentVotersCard_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "Letter_of_First_Appointment_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "Transfer_Acceptance_of_Service_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "StaffIDCard_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Employees", "Letter_of_Employment_byte", c => c.Binary(storeType: "image"));
            AddColumn("dbo.RsaStatus", "Code", c => c.String());
            AddColumn("dbo.SectorClassifications", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SectorClassifications", "Code");
            DropColumn("dbo.RsaStatus", "Code");
            DropColumn("dbo.Employees", "Letter_of_Employment_byte");
            DropColumn("dbo.Employees", "StaffIDCard_byte");
            DropColumn("dbo.Employees", "Transfer_Acceptance_of_Service_byte");
            DropColumn("dbo.Employees", "Letter_of_First_Appointment_byte");
            DropColumn("dbo.Employees", "PermanentVotersCard_byte");
            DropColumn("dbo.Employees", "DriversLicense_byte");
            DropColumn("dbo.Employees", "BirthCertificate_byte");
            DropColumn("dbo.Employees", "Signature_byte");
            DropColumn("dbo.Employees", "Photo_byte");
            DropColumn("dbo.Employees", "Intl_Passport_byte");
            DropColumn("dbo.Employees", "NIN_byte");
            DropColumn("dbo.Employees", "passport_byte");
        }
    }
}
