using FidelityPension.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace FidelityPension.Models.Core
{

    public class Employee : BaseEntity
    {
        public string PIN { get; set; }
        public int TitleId { get; set; }
        public virtual Title Title { get; set; }
        public string SURNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string OTHERNAMES { get; set; }
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        public string Mobile_Phone { get; set; }
        public string MaidenName { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Required(ErrorMessage = "Please specify your Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DATE_OF_BIRTH { get; set; }
        public string Place_of_Birth { get; set; }
        public int MARITAL_STATUSId { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public int NATIONALITYId { get; set; }
        public virtual Country Country { get; set; }
        public int STATE_OF_ORIGINId { get; set; }
        public virtual State State { get; set; }
        public int LGA_of_OriginId { get; set; }
        public virtual LGA LGA_of_Origin { get; set; }
        [RegularExpression(@"^[0-9]{11,16}$", ErrorMessage = "National Identity Number must not be less than 11 or greater than 16 ")]
        public string NIN { get; set; }
        public string NIN_Url { get; set;}
        [StringLength(11, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 11)]
        [RegularExpression(@"^[0-9]{11,16}$", ErrorMessage = "Bank Verification Number must not be less than 11 or greater than 16 ")]
        public string BVN { get; set; }
        public string Intl_Passport_No { get; set; }
        public string Photo_url { get; set; }
        public string FileNumber { get; set; }
        public string Signature_url { get; set; }
        public string BirthCertificate_Url { get; set; }
        public string Intl_Passport_Url { get; set; }
        public string DriversLicense_Url { get; set; }
        public string PermanentVotersCard_Url { get; set; }
        public string Letter_of_First_Appointment_Url { get; set; }
        public string Transfer_Acceptance_of_Service_Url { get; set; }
        public string StaffIDCard_Url { get; set; }
        public string Letter_of_Employment_Url { get; set; }
        public string Residential_Location { get; set; }
        public string Residential_Building_No { get; set; }
        public string Residential_Address { get; set; }
        public int? Country_of_residenceId { get; set; }
        public virtual Country Country_of_residence { get; set; }
        public int? State_of_residenceId { get; set; }
        public virtual State State_of_residence { get; set; }
        public int LGA_of_ResidenceId { get; set; }
        public virtual LGA LGA_of_Residence { get; set; }
        public string City_of_residence { get; set; }
        [EmailAddress]
        public string Personal_Email { get; set; }
        public string Correspondence_Building_No { get; set; }
        public string Correspondence_Address { get; set; }
        public int? Correspondence_CountryId { get; set; }
        public virtual Country Correspondence_Country { get; set; }
        public int? Correspondence_StateId { get; set; }
        public virtual State Correspondence_State { get; set; }
        public int Correspondence_LGAId { get; set; }
        public virtual LGA Correspondence_LGA { get; set; }

        public string Correspondence_ZipCode { get; set; }
        public string Correspondence_City { get; set; }
        public string Correspondenece_Mobile_No { get; set; }


        public string RSAPin { get; set; }
        public string PFA_Name { get; set; }
        public int RSAStatusId { get; set; }
        public virtual RsaStatus RsaStatus { get; set; }
        public string FormerPin1 { get; set; }
        public string FormerPFA1 { get; set; }
        public string FormerPin2 { get; set; }
        public string FormerPFA2 { get; set; }
        public string FormerPin3 { get; set; }
        public string FormerPFA3 { get; set; }
        public int? SectorClassificationId { get; set; }
        public virtual SectorClassification SectorClassification { get; set; }
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
        public int Employer_LGAId { get; set; }
        public virtual LGA Employer_LGA { get; set; }
        public string Employer_City { get; set; }
        public string Employer_Mobile_No { get; set; }
        public string Employer_Nature_of_Business { get; set; }
        public string Employee_IDNO { get; set; }
        public string Employer_Code { get; set; }
        public string Employer_Service_No { get; set; }
        public string Designation_Rank { get; set; }
        [EmailAddress]
        public string Employer_Official_Email { get; set; }
        public DateTime? Date_Of_First_Appointment { get; set; }
        public DateTime? Date_of_Current_Employment { get; set; }
        public DateTime? Date_of_Transfer_of_Service { get; set; }
        public DateTime? Date_of_retirement { get; set; }
        public string Employer_Zip_Code { get; set; }
        public string Harmonized_Salary_Structure_As_At_2004 { get; set; }
        public string GL_As_At_2004 { get; set; }
        public string Step_As_At_2004 { get; set; }
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
        public int? NOK_TitleId { get; set; }
        public virtual Title NOK_Title { get; set; }
        public string NOK_FIRSTNAME { get; set; }
        public string NOK_SURNAME { get; set; }
        public string NOK_MIDDLENAME { get; set; }
        public int? NOK_GenderId { get; set; }
        public virtual Gender NOk_Gender { get; set; }
        public int? NOK_CountryId { get; set; }
        public virtual Country NOK_Country { get; set; }
        public string NOK_Country_Location { get; set; }
        public DateTime? NOK_DOB { get; set; }
        public int? NOK_State_of_ResidenceId { get; set; }
        public virtual State NOK_State_of_Residence { get; set; }
        public int? NOK_LGA_of_ResidenceId { get; set; }
        public virtual LGA NOK_LGA_of_Residence { get; set; }

        public string NOK_City_of_residence { get; set; }
        public string NOK_Building_No { get; set; }
        public string NOK_ADDRESS { get; set; }
        public int? NOK_RELATIONSHIPId { get; set; }
        public virtual Relationship NOK_Relationship { get; set; }
        public string NOK_OFFICE_PHONE { get; set; }
        public string NOK_MOBILE_PHONE { get; set; }
        public string NOK_HOME_PHONE { get; set; }
        public string NOK_ZIP_CODE { get; set; }
        public string NOK_POBOX { get; set; }
        [EmailAddress]
        public string NOK_EMail { get; set; }
        public int? BENEFICIARY_TitleId { get; set; }
        public virtual Title Beneficiary_Title { get; set; }
        public string BENEFICIARY_FIRSTNAME { get; set; }
        public string BENEFICIARY_SURNAME { get; set; }
        public string BENEFICIARY_MIDDLENAME { get; set; }
        public int? BENEFICIARY_GenderId { get; set; }
        public virtual Gender Beneficiary_Gender { get; set; }
        public int? BENEFICIARY_Country_LocationId { get; set; }
        public virtual Country BENEFICIARY_Country_Location { get; set; }
        public int? BENEFICIARY_State_of_ResidenceId { get; set; }
        public virtual State BENEFICIARY_State_of_Residence { get; set; }
        public int? BENEFICIARY_LGA_of_ResidenceId { get; set; }
        public virtual LGA BENEFICIARY_LGA_of_Residence { get; set; }
        public string BENEFICIARY_City_of_residence { get; set; }
        public string BENEFICIARY_Building_No { get; set; }
        public string BENEFICIARY_ADDRESS { get; set; }
        public int? BENEFICIARY_RELATIONSHIPId { get; set; }
        public virtual Relationship Beneficiary_Relationship { get; set; }
        public string BENEFICIARY_OFFICE_PHONE { get; set; }
        public string BENEFICIARY_MOBILE_PHONE { get; set; }
        public string BENEFICIARY_HOME_PHONE { get; set; }
        public string BENEFICIARY_ZIP_CODE { get; set; }
        public DateTime? BENEFICIARY_DOB { get; set; }
        public string BENEFICIARY_POBOX { get; set; }
        [EmailAddress]
        public string BENEFICIARY_EMail { get; set; }
        [RegularExpression(@"^[0-9]{11,16}$", ErrorMessage = "National Identity Number must not be less than 11 or greater than 16")]
        public string BENEFICIARY_NIN { get; set; }
        [RegularExpression(@"^[0-9]{11,11}$", ErrorMessage = "BVN must not be less than 11 or greater than 11")]
        public string BENEFICIARY_BVN { get; set; }
        public bool HasAcceptedTnC { get; set; }
        public bool IsDetailsCompleted { get; set; }
        public bool HasPencomApproved { get; set; }
        public string AGENT_CODE { get; set; }
        public string FORM_REFNO { get; set; }


        [Column(TypeName = "image")]
        public byte[] consentFrom_byte { get; set; }

        [Column(TypeName = "image")]
        public byte[] passport_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] NIN_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] Intl_Passport_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] Signature_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] BirthCertificate_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] DriversLicense_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] PermanentVotersCard_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] Letter_of_First_Appointment_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] Transfer_Acceptance_of_Service_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] StaffIDCard_byte { get; set; }
        [Column(TypeName = "image")]
        public byte[] Letter_of_Employment_byte { get; set; }










        [NotMapped]
        public HttpPostedFileBase PhotoFileBase { get; set; }

        public string SavedPostedFileImagePhoto(string filePath, string imageOwner)
        {
            if (PhotoFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(PhotoFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "Photo" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                PhotoFileBase.SaveAs(path);
                Photo_url = imageUrl;


               


                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] photo_bytes = wc3.DownloadData(path2);
                Photo_byte = photo_bytes.ToArray();

                //Bitmap bmp_Photo = new Bitmap(path2);
                //FileStream fs_Photo = new FileStream(path2, FileMode.Open, FileAccess.Read);
                //var bimage_Photo = new byte[fs_Photo.Length];
                //fs_Photo.Read(bimage_Photo, 0, Convert.ToInt32(fs_Photo.Length));
                //Photo_byte = bimage_Photo;


            }
            return Photo_url;
        }

        //resize image 
        private Image Resize(Image img, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth, iHeight);
            bmp.SetResolution(300F, 300F);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, iWidth, iHeight);

            return (Image)bmp;
        }

        [NotMapped]
        public HttpPostedFileBase TransferAndAcceptanceOfServiceFileBase { get; set; }

        public string SavedPostedFileImageTransferAndAcceptanceOfService(string filePath, string imageOwner)
        {
            if (TransferAndAcceptanceOfServiceFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(TransferAndAcceptanceOfServiceFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "TOS" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                TransferAndAcceptanceOfServiceFileBase.SaveAs(path);
                Transfer_Acceptance_of_Service_Url = imageUrl;

                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                Transfer_Acceptance_of_Service_byte = converted_bytes.ToArray();

            }
            return Transfer_Acceptance_of_Service_Url;
        }

        [NotMapped]
        public HttpPostedFileBase letterOfFirstAppointmentFileBase { get; set; }

        public string SavedPostedFileImageletterOfFirstAppointment(string filePath, string imageOwner)
        {
            if (letterOfFirstAppointmentFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(letterOfFirstAppointmentFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "LOFA" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                letterOfFirstAppointmentFileBase.SaveAs(path);
                Letter_of_First_Appointment_Url = imageUrl;


                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                Letter_of_First_Appointment_byte = converted_bytes.ToArray();
            }
            return Letter_of_First_Appointment_Url;
        }

        [NotMapped]
        public HttpPostedFileBase letterOfEmploymentFileBase { get; set; }
        public string SavedPostedFileImageletterOfEmployment(string filePath, string imageOwner)
        {
            if (letterOfEmploymentFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(letterOfEmploymentFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "LOE" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                letterOfEmploymentFileBase.SaveAs(path);
                Letter_of_Employment_Url = imageUrl;


                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                Letter_of_Employment_byte = converted_bytes.ToArray();
            }
            return Letter_of_Employment_Url;
        }


        [NotMapped]
        public HttpPostedFileBase VotersCardFileBase { get; set; }

        public string SavedPostedFileImageVotersCard(string filePath, string imageOwner)
        {
            if (VotersCardFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(VotersCardFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "VoterCard" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                VotersCardFileBase.SaveAs(path);
                PermanentVotersCard_Url = imageUrl;


                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                PermanentVotersCard_byte = converted_bytes.ToArray();

            }
            return PermanentVotersCard_Url;
        }

        [NotMapped]
        public HttpPostedFileBase IntlPassportFileBase { get; set; }

        public string SavedPostedFileImageIntlPassport(string filePath, string imageOwner)
        {
            if (IntlPassportFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(IntlPassportFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "IntlPassport" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                IntlPassportFileBase.SaveAs(path);
                Intl_Passport_Url = imageUrl;

                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                Intl_Passport_byte = converted_bytes.ToArray();

            }
            return Intl_Passport_Url;
        }

        [NotMapped]
        public HttpPostedFileBase StaffIDCardFileBase { get; set; }

        public string SavedPostedFileImageStaffIDCard(string filePath, string imageOwner)
        {
            if (StaffIDCardFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(StaffIDCardFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "StaffID" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                StaffIDCardFileBase.SaveAs(path);
                StaffIDCard_Url = imageUrl;


                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                StaffIDCard_byte = converted_bytes.ToArray();

            }
            return StaffIDCard_Url;
        }


        [NotMapped]
        public HttpPostedFileBase NINFileBase { get; set; }

        public string SavedPostedFileImageNIN(string filePath, string imageOwner)
        {
            if (NINFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(NINFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "NIN" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                NINFileBase.SaveAs(path);
                NIN_Url = imageUrl;


                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                NIN_byte = converted_bytes.ToArray();


            }
            return NIN_Url;
        }


        [NotMapped]
        public HttpPostedFileBase SignatureFileBase { get; set; }

        public string SavedPostedFileImageSignature(string filePath, string imageOwner)
        {
            if (SignatureFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(SignatureFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "Signature" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                SignatureFileBase.SaveAs(path);
                Signature_url = imageUrl;

                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                Signature_byte = converted_bytes.ToArray();

            }
            return Signature_url;
        }

        [NotMapped]
        public HttpPostedFileBase BerthCertFileBase { get; set; }

        public string SavedPostedFileImageBerthCert(string filePath, string imageOwner)
        {
            if (BerthCertFileBase != null)
            {
                var mainFolder = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
                var subFolder = imageOwner.TrimEnd('.');
                var fileExtension = Path.GetExtension(BerthCertFileBase.FileName);
                var fileName = DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") +
                            (new Random().Next(1000, 9999)) + "BirthCert" + fileExtension;
                var path = mainFolder + subFolder.TrimEnd('.') + "\\" + fileName;
                var imageUrl = @"/UploadedImages/" + subFolder.TrimEnd('.') + @"/" + fileName;

                if (!Directory.Exists(mainFolder + subFolder))
                    Directory.CreateDirectory(mainFolder + subFolder);

                BerthCertFileBase.SaveAs(path);
                BirthCertificate_Url = imageUrl;

                var path2 = mainFolder + subFolder.TrimEnd('.') + "\\" + "resizedImage_" + fileName;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(path);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                var iWidth = 100;
                var iHeight = 100;

                img = Resize(img, iWidth, iHeight);

                img.Save(path2);

                WebClient wc3 = new WebClient();
                byte[] converted_bytes = wc3.DownloadData(path2);
                BirthCertificate_byte = converted_bytes.ToArray();
            }
            return BirthCertificate_Url;
        }

        public long ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }    
    }
}