using FidelityPension.Models.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FidelityPension.ViewModels
{
    public class EmployeeViewModel : BaseEntity
    {
        public string PIN { get; set; }
        public string TITLE { get; set; }
        public string SURNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string OTHERNAMES { get; set; }
        public string GENDER { get; set; }
        public string MaidenName { get; set; }
        public DateTime? DATE_OF_BIRTH { get; set; }
        public string Place_of_Birth { get; set; }
        public string MARITAL_STATUS { get; set; }
        public int NATIONALITYId { get; set; }
        public virtual Country Country { get; set; }
        public int STATE_OF_ORIGINId { get; set; }
        public virtual State State { get; set; }
        public int LGA_of_originId { get; set; }
        public virtual City LGA { get; set; }
        public string NIN { get; set; }
        public string BVN { get; set; }
        public string Photo_url { get; set; }
        public string Signature_url { get; set; }
        public string Residential_Location { get; set; }
        public string Residential_Address { get; set; }
        public int Country_of_residenceId { get; set; }
        public virtual Country Country_of_residence { get; set; }
        public int State_of_residenceId { get; set; }
        public virtual State State_of_residence { get; set; }
        public int LGA_of_residenceId { get; set; }
        public virtual LGA LGA_of_residence { get; set; }
        public string City_of_residence { get; set; }
        public string Personal_Email { get; set; }
        public string Correspondence_Address { get; set; }
        public int? Correspondence_CountryId { get; set; }
        public virtual Country Correspondence_Country { get; set; }
        public int? Correspondence_StateId { get; set; }
        public virtual State Correspondence_State { get; set; }
        public int? Correspondence_LGAId { get; set; }
        public virtual LGA Correspondence_LGA { get; set; }
        public string Correspondence_City { get; set; }
        public string Correspondenece_Mobile_No { get; set; }


        public string RSAPin { get; set; }
        public bool RSAStatus { get; set; }
        public string FormerPin1 { get; set; }
        public string FormerPFA1 { get; set; }
        public string FormerPin2 { get; set; }
        public string FormerPFA2 { get; set; }
        public string FormerPin3 { get; set; }
        public string FormerPFA3 { get; set; }
        public int? SectorClassification { get; set; }
        public bool IsEmployerUnderIPPIS { get; set; }
        public DateTime? DateEmployeeJoinedIPPIS { get; set; }
        public string EmployeeIPPISNo { get; set; }
        public string EMPLOYER_FULLNAME { get; set; }
        public string EMPLOYER_ADDRESS { get; set; }
        public string Employer_Country_Location { get; set; }
        public string Employer_Building_No { get; set; }
        public int? Employer_CountryId { get; set; }
        public virtual Country Employer_Country { get; set; }
        public int? Employer_StateId { get; set; }
        public virtual State Employer_State { get; set; }
        public int? Employer_LGAId { get; set; }
        public virtual LGA Employer_LGA { get; set; }
        public string Employer_City { get; set; }
        public string Employer_Mobile_No { get; set; }
        public string Employer_Nature_of_Business { get; set; }
        public string Employer_NO { get; set; }
        public string Employer_Service_No { get; set; }
        public string Designation_Rank { get; set; }
        public string Employer_Official_Email { get; set; }
        public DateTime? Date_Of_First_Appointment { get; set; }
        public DateTime? Date_of_Current_Employment { get; set; }
        public DateTime? Date_of_Transfer_of_Service { get; set; }
        public DateTime? Date_of_retirement { get; set; }
        public string Employer_Zip_Code { get; set; }
        public string Harmonized_Salary_Structure_As_At_2004 { get; set; }
        public string Consolidated_Salary_Structure_As_At_2007 { get; set; }
        public string GL_As_At_2007 { get; set; }
        public string Step_As_At_2007 { get; set; }
        public string Enhanced_Consolidated_Salary_Structure_As_At_2010 { get; set; }
        public string GL_As_At_2010 { get; set; }
        public string Step_As_At_2010 { get; set; }
        public string Enhanced_Consolidated_Salary_Structure_As_At_2013 { get; set; }
        public string GL_As_At_2013 { get; set; }
        public string Step_As_At_2013 { get; set; }
        public string Enhanced_Consolidated_Salary_Structure_As_At_2016 { get; set; }
        public string GL_As_At_2016 { get; set; }
        public string Step_As_At_2016 { get; set; }
        public string Current_Salary_Structure { get; set; }
        public string Current_GL { get; set; }
        public string Current_Step { get; set; }
        public int NOK_Title { get; set; }
        public string NOK_FIRSTNAME { get; set; }
        public string NOK_SURNAME { get; set; }
        public string NOK_MIDDLENAME { get; set; }
        public string NOK_Gender { get; set; }
        public int? NOK_Country_LocationId { get; set; }
        public virtual Country NOK_Country_Location { get; set; }
        public int? NOK_State_of_ResidenceId { get; set; }
        public virtual State NOK_State_of_Residence { get; set; }
        public int? NOK_LGA_of_residenceId { get; set; }
        public virtual LGA NOK_LGA_of_Residence { get; set; }
        public string NOK_City_of_residence { get; set; }
        public string NOK_ADDRESS { get; set; }
        public string NOK_RELATIONSHIP { get; set; }
        public string NOK_OFFICE_PHONE { get; set; }
        public string NOK_MOBILE_PHONE { get; set; }
        public string NOK_HOME_PHONE { get; set; }
        public string NOK_ZIP_CODE { get; set; }
        public string NOK_POBOX { get; set; }
        public string NOK_EMail { get; set; }
        public int BENEFICIARY_Title { get; set; }
        public string BENEFICIARY_FIRSTNAME { get; set; }
        public string BENEFICIARY_SURNAME { get; set; }
        public string BENEFICIARY_MIDDLENAME { get; set; }
        public string BENEFICIARY_Gender { get; set; }
        public int? BENEFICIARY_Country_LocationId { get; set; }
        public virtual Country BENEFICIARY_Country_Location { get; set; }
        public int? BENEFICIARY_State_of_ResidenceId { get; set; }
        public virtual State BENEFICIARY_State_of_Residence { get; set; }
        public int? BENEFICIARY_LGA_of_residenceId { get; set; }
        public virtual LGA BENEFICIARY_LGA_of_Residence { get; set; }
        public string BENEFICIARY_City_of_residence { get; set; }
        public string BENEFICIARY_ADDRESS { get; set; }
        public string BENEFICIARY_RELATIONSHIP { get; set; }
        public string BENEFICIARY_OFFICE_PHONE { get; set; }
        public string BENEFICIARY_MOBILE_PHONE { get; set; }
        public string BENEFICIARY_HOME_PHONE { get; set; }
        public string BENEFICIARY_ZIP_CODE { get; set; }
        public string BENEFICIARY_POBOX { get; set; }
        public string BENEFICIARY_EMail { get; set; }
        public string BENEFICIARY_NIN { get; set; }
        public string BENEFICIARY_BVN { get; set; }
        public bool HasAcceptedTnC { get; set; }
        public string AGENT_CODE { get; set; }

        public HttpPostedFileBase PhotoFileBase { get; set; }

        public string SavedPostedFileImagePhoto(string filePath, string imageOwner)
        {
            if (PhotoFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(PhotoFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                PhotoFileBase.SaveAs(path);
                Photo_url = imageUrl;
            }
            return Photo_url;
        }

        public HttpPostedFileBase SignatureFileBase { get; set; }

        public string SavedPostedFileImageSignature(string filePath, string imageOwner)
        {
            if (SignatureFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(SignatureFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                SignatureFileBase.SaveAs(path);
                Signature_url = imageUrl;
            }
            return Signature_url;
        }
    }
}