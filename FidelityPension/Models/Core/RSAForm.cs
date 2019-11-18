using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class RSAForm : BaseEntity
    {
        public string RSAPin { get; set; }
        public string Passport { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string MaidenName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DOB { get; set; }
        public string PlaceOfBirth { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Phone]
        public string MobileNo { get; set; }
        public string NIN { get; set; }
        public int BVN { get; set; }
        public int IPN { get; set; }
        public int NATIONALITY_ID { get; set; }
        public virtual Country Country { get; set; }
        public int STATE_OF_ORIGIN_ID { get; set; }
        public virtual State State { get; set; }
        public int LGA_ID { get; set; }
        public virtual City LGA { get; set; }
        public string Residential_Address_Location { get; set; }
        public string Residential_Address { get; set; }
        public string City_of_Resident { get; set; }
        public int LGA_of_Resident_ID { get; set; }
        public virtual LGA LGA_of_Resident { get; set; }
        public int State_of_Resident_ID { get; set; }
        public virtual State State_of_Resident { get; set; }
        public int Country_of_Resident_ID { get; set; }
        public virtual Country Country_of_Resident { get; set; }

        public string Correspondence_Address_Location { get; set; }
        public string Correspondence_Address { get; set; }
        public string Correspondence_City_of_Resident { get; set; }
        public int Correspondence_LGA_of_Resident_ID { get; set; }
        public virtual LGA Correspondence_LGA_of_Resident { get; set; }
        public int Correspondence_State_of_Resident_ID { get; set; }
        public virtual State Correspondence_State_of_Resident { get; set; }
        public int Correspondence_Country_of_Resident_ID { get; set; }
        public virtual Country Correspondence_Country_of_Resident { get; set; }
        public string Correspondence_Zip_Code { get; set; }
        public string Correspondence_PO_Box { get; set; }

        public int Sector_Classification { get; set; }
        public bool Is_Employer_Under_IPPIS { get; set; }
        public DateTime? Date_Employee_Joined_IPPIS { get; set; }
        public string Employees_IPPIS_No { get; set; }
        public string Employer_Name { get; set; }
        public string Employer_Phone { get; set; }
        public string Employer_Address { get; set; }
        public string Nature_of_Business { get; set; }
        public string Employer_Email { get; set; }
        public string Designation_Rank { get; set; }
        public string EmployerID { get; set; }
        public string ServiceID { get; set; }
        public string Employer_Location { get; set; }
        public int Employer_Country_ID { get; set; }
        public virtual Country Employer_Country { get; set; }
        public int Employer_State_ID { get; set; }
        public virtual State Employer_State { get; set; }
        public int Employer_LGA_ID { get; set; }
        public virtual LGA Employer_LGA { get; set; }
        public string Employer_Zip_Code { get; set; }
        public string Employer_PO_Box { get; set; }
    }
}