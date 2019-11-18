using FidelityPension.Areas.iPension.viewModels;
using FidelityPension.Models;
using FidelityPension.Models.Core;
using FidelityPension.Models.DAL;
using FidelityPension.Utility;
using log4net;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace FidelityPension.Areas.iPension.Controllers
{
    public class RSAController : Controller
    {
        private readonly ILog Logger = LogManager.GetLogger(typeof(RSAController));

        private ApplicationDbContext context = new ApplicationDbContext();
        private PfaDbContext1 db = new PfaDbContext1();

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        private static RestClient client;

        public RSAController()
        {
        }

        public RSAController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }



        // GET: iPension/Rsa
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult RegistrationForm()
        {
            return View();
        }


        [Authorize]
        public ActionResult RecaptureForm(string search)
        {
            var user = User.Identity.GetUserName();
            Session["PIN"] = user;
            if (user.StartsWith("PEN"))
            {
                if (search == null)
                {
                    search = user;
                }
                ViewBag.HideSearchBar = true;
            }
            else
            {
                ViewBag.HideSearchBar = false;
            }

            if (search != null)
            {
                var result = context.Employees.FirstOrDefault(x => x.PIN == search);
                if (result != null && result.IsDetailsCompleted == true)
                {
                    ViewBag.RecaptureWarningErrorMsg = $"This Pin: {search} has been recaptured, you can't make any modifications on this again. Click on View Profile on the left navigation bar to view your profile.";
                    @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
                    ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
                    Logger.DebugFormat($"Error While Saving Recaptured Data.");
                    Session["Name"] = result.FIRSTNAME + " " + result.SURNAME;
                    Session["photo"] = result.Photo_url;
                    Session["Id"] = result.Id;
                    ViewBag.Hide = 1;
                    return View();
                }
                else if (result != null && result.IsDetailsCompleted == false)
                {
                    Session["Name"] = result.FIRSTNAME + " " + result.SURNAME;
                    Session["photo"] = $"http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/Passports/{user}.jpg";
                   // var pix = $"http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/GetProfilePic/{user}";
                    Session["Id"] = result.Id;
                    var EmployeeModel = new Employee
                    {
                        PIN = result.PIN,
                        FIRSTNAME = result.FIRSTNAME,
                        SURNAME = result.SURNAME,
                        OTHERNAMES = result.OTHERNAMES,
                        DATE_OF_BIRTH = result.DATE_OF_BIRTH,
                        EMPLOYER_FULLNAME = result.EMPLOYER_FULLNAME,
                        EMPLOYER_ADDRESS = result.EMPLOYER_ADDRESS,
                        Employer_Building_No = result.EMPLOYER_ADDRESS,
                        BVN = result.BVN,
                        NIN = result.NIN,
                        Place_of_Birth = result.Place_of_Birth,
                        NATIONALITYId = result.NATIONALITYId,
                        STATE_OF_ORIGINId = result.STATE_OF_ORIGINId,
                        LGA_of_OriginId = result.LGA_of_OriginId,
                        LGA_of_ResidenceId = result.LGA_of_ResidenceId,
                        City_of_residence = result.City_of_residence,
                        Residential_Location = result.Residential_Location,
                        State_of_residenceId = result.State_of_residenceId,
                        RSAStatusId = result.RSAStatusId,
                        PFA_Name = result.PFA_Name,
                        Employer_Code = result.Employer_Code,
                        Personal_Email = result.Personal_Email,
                        Residential_Address = result.Residential_Address,
                        Residential_Building_No = result.Residential_Building_No,
                        Correspondence_Address = result.Correspondence_Address,
                        Correspondenece_Mobile_No = result.Correspondenece_Mobile_No,
                        Correspondence_Building_No = result.Correspondence_Building_No,
                        Mobile_Phone = result.Mobile_Phone,
                        NOK_SURNAME = result.NOK_SURNAME,
                        NOK_FIRSTNAME = result.NOK_FIRSTNAME,
                        NOK_MIDDLENAME = result.NOK_MIDDLENAME,
                        NOK_ADDRESS = result.NOK_ADDRESS,
                        NOK_EMail = result.NOK_EMail == null || result.NOK_EMail == "" ? result.Personal_Email : result.NOK_EMail,
                        NOK_MOBILE_PHONE = result.NOK_MOBILE_PHONE,
                        NOK_POBOX = result.NOK_POBOX,
                        NOK_ZIP_CODE = result.NOK_ZIP_CODE,
                        RSAPin = result.PIN,
                        MaidenName = result.MaidenName,
                        AGENT_CODE = result.AGENT_CODE,
                        TitleId = result.TitleId,
                        MARITAL_STATUSId = result.MARITAL_STATUSId,
                        GenderId = result.GenderId,
                        NOK_RELATIONSHIPId = result.NOK_RELATIONSHIPId,
                        NOK_GenderId = result.NOK_GenderId,
                        NOK_TitleId = result.NOK_TitleId,
                        NOK_CountryId = result.NOK_CountryId,
                        NOK_State_of_ResidenceId = result.NOK_State_of_ResidenceId,
                        NOK_City_of_residence = result.NOK_City_of_residence,
                        NOK_LGA_of_ResidenceId = result.NOK_LGA_of_ResidenceId,
                        NOK_Country_Location = result.NOK_Country_Location,
                        BENEFICIARY_ADDRESS = result.BENEFICIARY_ADDRESS,
                        BENEFICIARY_EMail = result.BENEFICIARY_EMail,
                        BENEFICIARY_BVN = result.BENEFICIARY_BVN,
                        BENEFICIARY_City_of_residence = result.BENEFICIARY_City_of_residence,
                        BENEFICIARY_Country_LocationId = result.BENEFICIARY_Country_LocationId,
                        BENEFICIARY_FIRSTNAME = result.BENEFICIARY_FIRSTNAME,
                        BENEFICIARY_GenderId = result.BENEFICIARY_GenderId,
                        BENEFICIARY_HOME_PHONE = result.BENEFICIARY_HOME_PHONE,
                        BENEFICIARY_LGA_of_ResidenceId = result.BENEFICIARY_LGA_of_ResidenceId,
                        BENEFICIARY_MIDDLENAME = result.BENEFICIARY_MIDDLENAME,
                        BENEFICIARY_MOBILE_PHONE = result.BENEFICIARY_MOBILE_PHONE,
                        BENEFICIARY_NIN = result.BENEFICIARY_NIN,
                        BENEFICIARY_OFFICE_PHONE = result.BENEFICIARY_OFFICE_PHONE,
                        BENEFICIARY_POBOX = result.BENEFICIARY_POBOX,
                        BENEFICIARY_RELATIONSHIPId = result.BENEFICIARY_RELATIONSHIPId,
                        BENEFICIARY_State_of_ResidenceId = result.BENEFICIARY_State_of_ResidenceId,
                        BENEFICIARY_SURNAME = result.BENEFICIARY_SURNAME,
                        BENEFICIARY_TitleId = result.BENEFICIARY_TitleId,
                        BENEFICIARY_ZIP_CODE = result.BENEFICIARY_ZIP_CODE,
                        Consolidated_Salary_Structure_As_At_2007 = result.Consolidated_Salary_Structure_As_At_2007,
                        Current_GL = result.Current_GL,
                        Current_Salary_Structure = result.Current_Salary_Structure,
                        Current_Step = result.Current_Step,
                        Correspondence_City = result.Correspondence_City,
                        Correspondence_CountryId = result.Correspondence_CountryId,
                        Correspondence_LGAId = result.Correspondence_LGAId,
                        Correspondence_StateId = result.Correspondence_StateId,
                        Correspondence_ZipCode = result.Correspondence_ZipCode,
                        Country_of_residenceId = result.Country_of_residenceId,
                        DateEmployeeJoinedIPPIS = result.DateEmployeeJoinedIPPIS,
                        Date_of_Current_Employment = result.Date_of_Current_Employment,
                        Date_Of_First_Appointment = result.Date_Of_First_Appointment,
                        Date_of_retirement = result.Date_of_retirement,
                        Date_of_Transfer_of_Service = result.Date_of_Transfer_of_Service,
                        Designation_Rank = result.Designation_Rank,
                        EmployeeIPPISNo = result.EmployeeIPPISNo,
                        SectorClassificationId = result.SectorClassificationId,
                        IsEmployerUnderIPPIS = result.IsEmployerUnderIPPIS,
                        Employee_IDNO = result.Employee_IDNO,
                        Employer_City = result.Employer_City,
                        Employer_CountryId = result.Employer_CountryId,
                        Employer_Country_Location = result.Employer_Country_Location,
                        Employer_LGAId = result.Employer_LGAId,
                        Employer_Mobile_No = result.Employer_Mobile_No,
                        Employer_Nature_of_Business = result.Employer_Nature_of_Business,
                        Employer_Official_Email = result.Employer_Official_Email,
                        Employer_Service_No = result.Employer_Service_No,
                        Employer_StateId = result.Employer_StateId,
                        Employer_Zip_Code = result.Employer_Zip_Code,
                        Enhanced_Consolidated_Salary_Structure_As_At_2010 = result.Enhanced_Consolidated_Salary_Structure_As_At_2010,
                        Enhanced_Consolidated_Salary_Structure_As_At_2013 = result.Enhanced_Consolidated_Salary_Structure_As_At_2013,
                        Enhanced_Consolidated_Salary_Structure_As_At_2016 = result.Enhanced_Consolidated_Salary_Structure_As_At_2016,
                        FileNumber = result.FileNumber,
                        FormerPFA1 = result.FormerPFA1,
                        FormerPFA2 = result.FormerPFA2,
                        FormerPFA3 = result.FormerPFA3,
                        FormerPin1 = result.FormerPin1,
                        FormerPin2 = result.FormerPin2,
                        FormerPin3 = result.FormerPin3,
                        GL_As_At_2004 = result.GL_As_At_2004,
                        GL_As_At_2007 = result.GL_As_At_2007,
                        GL_As_At_2010 = result.GL_As_At_2010,
                        GL_As_At_2013 = result.GL_As_At_2013,
                        GL_As_At_2016 = result.GL_As_At_2016,
                        Step_As_At_2004 = result.Step_As_At_2004,
                        Step_As_At_2007 = result.Step_As_At_2007,
                        Step_As_At_2010 = result.Step_As_At_2010,
                        Step_As_At_2013 = result.Step_As_At_2013,
                        Step_As_At_2016 = result.Step_As_At_2016,
                        Harmonized_Salary_Structure_As_At_2004 = result.Harmonized_Salary_Structure_As_At_2004,
                        Id = result.Id,

                    };
                    ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
                    @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Where(x => x.NAME == result.EMPLOYER_FULLNAME), "TRANSID", "NAME");
                    ViewBag.PinValid = 1;
                    ViewBag.photo_url = result.Photo_url;
                    ViewBag.signatur_url = result.Signature_url;
                    Logger.DebugFormat($"Found record PIN: {search} in Employee Table in iPension DB.");
                    //PopulateEmployersDropDownList(result.EMPLOYER_FULLNAME);
                    return View(EmployeeModel);

                }


                var qResult = user.StartsWith("PEN") ? db.EMPLOYEES.FirstOrDefault(x => x.PIN == user) : db.EMPLOYEES.FirstOrDefault(x => x.PIN == search);
                if (qResult != null)
                {

                    Session["Name"] = qResult.FIRSTNAME + " " + qResult.SURNAME;

                    ViewBag.Date = 1;

                    int conv_titleID = 0;
                    if (qResult.TITLE != null)
                    {
                        var query = context.Titles.FirstOrDefault(x => x.Value == qResult.TITLE);
                        conv_titleID = query == null ? 1 : Convert.ToInt32(query.Id);
                    }
                    int conv_maritalStatusID = 0;
                    if (qResult.MARITAL_STATUS_CODE != null)
                    {

                        var query = context.MaritalStatus.FirstOrDefault(x => x.Value.StartsWith(qResult.MARITAL_STATUS_CODE.Substring(0, 1)));
                        conv_maritalStatusID = query == null ? 1 : Convert.ToInt32(query.Id);
                    }
                    int conv_genderID = 0;
                    if (qResult.GENDER != null)
                    {
                        var query = context.Genders.FirstOrDefault(x => x.Value.StartsWith(qResult.GENDER));
                        conv_genderID = query == null ? 1 : Convert.ToInt32(query.Id);
                    }
                    int conv_relationshipID = 0;
                    if (qResult.NOK_RELATIONSHIP != null)
                    {
                       var query = context.Relationships.FirstOrDefault(x => x.Value == qResult.NOK_RELATIONSHIP);
                        conv_relationshipID = query == null ? 1 : Convert.ToInt32(query.Id);

                    }
                    int c_genderId = 0;
                    if (qResult.NOK_GENDER != null)
                    {
                        var query = context.Genders.FirstOrDefault(x => x.Value.StartsWith(qResult.NOK_GENDER));
                        c_genderId = query == null ? 1 : Convert.ToInt32(query.Id);
                    }
                    int c_noktitleId = 0;
                    if (qResult.NOK_TITLE != null)
                    {
                        var query = context.Titles.FirstOrDefault(x => x.Value == qResult.NOK_TITLE);
                        c_noktitleId = query == null ? 1 : Convert.ToInt32(query.Id);
                    }


                    //DateTime? date = qResult.DATE_OF_BIRTH;
                    var EmployeeModel = new Employee
                    {
                        PIN = qResult.PIN,
                        FIRSTNAME = qResult.FIRSTNAME,
                        SURNAME = qResult.SURNAME,
                        OTHERNAMES = qResult.OTHERNAMES,
                        DATE_OF_BIRTH = qResult.DATE_OF_BIRTH,
                        EMPLOYER_FULLNAME = qResult.EMPLOYER_NAME,
                        EMPLOYER_ADDRESS = qResult.EMPLOYER_ADDRESS,
                        Employer_Building_No = qResult.EMPLOYER_ADDRESS,
                        Employer_Code = qResult.EMPLOYER_RCNO,
                        Personal_Email = qResult.EMAIL,
                        Residential_Address = qResult.PERMANENT_ADDRESS,
                        Correspondence_Address = qResult.PERMANENT_ADDRESS,
                        Correspondenece_Mobile_No = qResult.MOBILE_PHONE,
                        Mobile_Phone = qResult.MOBILE_PHONE,
                        NOK_SURNAME = qResult.NOK_SURNAME,
                        NOK_FIRSTNAME = qResult.NOK_NAME,
                        NOK_MIDDLENAME = qResult.NOK_OTHERNAME,
                        NOK_ADDRESS = qResult.NOK_ADDRESS,
                        NOK_EMail =  qResult.EMAIL,
                        NOK_MOBILE_PHONE = qResult.NOK_MOBILE_PHONE,
                        RSAPin = qResult.PIN,
                        MaidenName = qResult.MAIDEN_NAME,
                        AGENT_CODE = qResult.AGENT_CODE,
                        TitleId = conv_titleID,
                        MARITAL_STATUSId = conv_maritalStatusID,
                        GenderId = conv_genderID,
                        NOK_RELATIONSHIPId = conv_relationshipID,
                        NOK_GenderId = c_genderId,
                        NOK_TitleId = c_noktitleId



                    };

                    @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Where(x => x.RCNO == qResult.EMPLOYER_RCNO), "TRANSID", "NAME");

                    //PopulateEmployerNameDropDownList(qResult.EMPLOYER_RCNO);
                    PopulatePfaNameDropDownList(qResult.PFA_CODE);

                    ViewBag.recordFound = $"Pin: {search} is correct! The personal data section has been populated with existing record, please check to see if its correct and fill any missing fields.";
                    ViewBag.PinValid = 1;

                    Logger.DebugFormat($"Pin: {search} is correct! The personal data section has been populated with existing record, please check to see if its correct and fill any missing fields.");

                    return View(EmployeeModel);

                }
                else
                {
                   
                    ViewBag.error = $"The Pin: {search} you are searching for does not exist.";
                    ViewBag.errorCode = 1;
                    @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
                    ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");

                    Logger.DebugFormat($"The Pin: {search} you are searching for does not exist.");

                 
                    ViewBag.Hide = 1;
                    return View();
                }
            }
            @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
            ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
            return View();
        }


        private void PopulateEmployersDropDownList(object selectedValue = null)
        {
            PfaDbContext1 db = new PfaDbContext1();
            var data = from d in db.EMPLOYER_DETAILS
                                      orderby d.NAME
                                      select d;
            ViewBag.EmpoyerName = new SelectList(data, "TRANSID", "NAME", selectedValue);
        }

        public ActionResult GoogleTranslatorApi(string input, string languagePair)
        {
            ViewBag.Result = GoogleTranslateText(input, languagePair);
            return View();
        }


        public static string GoogleTranslateText(string input, string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
            result = result.Substring(result.IndexOf(">") + 1);
            result = result.Substring(0, result.IndexOf("</span>"));
            return result.Trim();
        }

        private void PopulateEmployerNameDropDownList(object selectedValue = null)
        {
            var employernameQuery = from d in db.EMPLOYER_DETAILS
                                    orderby d.EMPLOYER_ID
                                    select d;
            ViewBag.EmpoyerName = new SelectList(employernameQuery.Take(20), "TRANSID", "NAME", selectedValue);
        }

        private void PopulatePfaNameDropDownList(object selectedValue = null)
        {
            var Query = from d in db.PFAs
                        orderby d.PFA_CODE
                        select d;
            ViewBag.PfaName = new SelectList(Query, "PFA_CODE", "PFA_NAME", selectedValue);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RecaptureForm(Employee model)
        {
            try
            {
                var fidManager = HttpContext.GetOwinContext().Get<FidManager>();

                if (ModelState.IsValid)
                {
                    var qResult = context.Employees.FirstOrDefault(x => x.PIN == model.RSAPin && x.IsDetailsCompleted == true);
                    if (qResult != null)
                    {
                        ViewBag.RecaptureWarningErrorMsg = $"This Pin: {model.RSAPin} has been recaptured, you can't make any modifications on this again.";
                        @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
                        ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
                        Logger.DebugFormat($"Error While Saving Recaptured Data.");

                        ViewBag.Hide = 1;
                        return View();
                    }
                    else
                    {
                        var FileNumber = model.RSAPin; /*fidManager.GetNewUserFileNumber();*/ /*"F45HHG778";*/

                        model.PIN = model.RSAPin;
                        model.FileNumber = FileNumber;
                        var consentForm = Request["imageCanvas"];
                        if (model.Id != 0)
                        {

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImagePhoto(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageSignature(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageStaffIDCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageBerthCert(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageIntlPassport(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageletterOfFirstAppointment(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageTransferAndAcceptanceOfService(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageVotersCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            ////TODO: Saving Staff's Profile Picture
                            //model.SavedPostedFileImageNIN(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                            //        FileNumber);

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImagePhoto(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Photo_url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageSignature(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Signature_url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageStaffIDCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.StaffIDCard_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageBerthCert(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.BirthCertificate_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageIntlPassport(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Intl_Passport_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageletterOfFirstAppointment(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Letter_of_First_Appointment_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageletterOfEmployment(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Letter_of_Employment_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageTransferAndAcceptanceOfService(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Transfer_Acceptance_of_Service_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageVotersCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.PermanentVotersCard_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageNIN(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.NIN_Url}");

                          // var ConsentFormImage =  SaveConsentImage(consentForm, model.PIN);

                            var query = context.Employees.Find(model.Id);

                            string pfa_val = Request["PfaName"];
                            long empName_val = Convert.ToInt32(Request["EmpoyerName"]);
                            var PFA_NAME_val = db.PFAs.FirstOrDefault(x => x.PFA_CODE == pfa_val).PFA_NAME;
                            var EmployerDetails_val = db.EMPLOYER_DETAILS.FirstOrDefault(x => x.TRANSID == empName_val);


                            query.Photo_byte = model.Photo_byte;
                            query.passport_byte = model.Photo_byte;
                            query.Signature_byte = model.Signature_byte;
                            query.StaffIDCard_byte = model.StaffIDCard_byte;
                            query.Intl_Passport_byte = model.Intl_Passport_byte;
                            query.PermanentVotersCard_byte = model.PermanentVotersCard_byte;
                            query.BirthCertificate_byte = model.BirthCertificate_byte;
                            query.Letter_of_Employment_byte = model.Letter_of_Employment_byte;
                            query.Letter_of_First_Appointment_byte = model.Letter_of_First_Appointment_byte;
                            query.NIN_byte = model.NIN_byte;
                            query.Transfer_Acceptance_of_Service_byte = model.Transfer_Acceptance_of_Service_byte;

                            query.TitleId = model.TitleId;
                            query.Title = context.Titles.Find(model.TitleId);
                            query.FIRSTNAME = model.FIRSTNAME;
                            query.SURNAME = model.SURNAME;
                            query.MaidenName = model.MaidenName;
                            query.MaritalStatus = context.MaritalStatus.Find(model.MARITAL_STATUSId);
                            query.MARITAL_STATUSId = model.MARITAL_STATUSId;
                            query.Mobile_Phone = model.Mobile_Phone;
                            query.NATIONALITYId = model.NATIONALITYId;
                            query.NIN = model.NIN;
                            query.BVN = model.BVN;
                            query.Place_of_Birth = model.Place_of_Birth;
                            query.Correspondence_City = model.Correspondence_City;
                            query.Employer_City = model.Employer_City;
                            query.Employer_Mobile_No = model.Employer_Mobile_No;
                            query.Photo_url = model.Photo_url == null ? query.Photo_url : model.Photo_url;
                            query.Signature_url = model.Signature_url == null ? query.Signature_url : model.Signature_url;
                            query.PermanentVotersCard_Url = model.PermanentVotersCard_Url == null ? query.PermanentVotersCard_Url : model.PermanentVotersCard_Url;
                            query.StaffIDCard_Url = model.StaffIDCard_Url == null ? query.StaffIDCard_Url : model.StaffIDCard_Url;
                            query.BirthCertificate_Url = model.BirthCertificate_Url == null ? query.BirthCertificate_Url : model.BirthCertificate_Url;
                            query.NIN_Url = model.NIN_Url == null ? query.NIN_Url : model.NIN_Url;
                            query.Intl_Passport_Url = model.Intl_Passport_Url == null ? query.Intl_Passport_Url : model.Intl_Passport_Url;
                            query.Transfer_Acceptance_of_Service_Url = model.Transfer_Acceptance_of_Service_Url == null ? query.Transfer_Acceptance_of_Service_Url : model.Transfer_Acceptance_of_Service_Url;
                            query.Letter_of_Employment_Url = model.Letter_of_Employment_Url == null ? query.Letter_of_Employment_Url : model.Letter_of_Employment_Url;
                            query.Letter_of_First_Appointment_Url = model.Letter_of_First_Appointment_Url == null ? query.Letter_of_First_Appointment_Url : model.Letter_of_First_Appointment_Url;
                            query.OTHERNAMES = model.OTHERNAMES;
                            query.PermanentVotersCard_Url = model.PermanentVotersCard_Url;
                            query.Personal_Email = model.Personal_Email;                       
                            query.Place_of_Birth = model.Place_of_Birth;
                            query.BENEFICIARY_Building_No = model.BENEFICIARY_Building_No;
                            query.Correspondence_Building_No = model.Correspondence_Building_No;
                            query.Employer_Building_No = model.Employer_Building_No;
                            query.NOK_Building_No = model.NOK_Building_No;
                            query.Residential_Building_No = model.Residential_Building_No;
                            query.Employer_Nature_of_Business = model.Employer_Nature_of_Business;
                            query.Residential_Address = model.Residential_Address;
                            query.Residential_Location = model.Residential_Location;
                            query.Personal_Email = model.Personal_Email;                     
                            query.State = context.States.Find(model.STATE_OF_ORIGINId);
                            query.STATE_OF_ORIGINId = model.STATE_OF_ORIGINId;
                            query.State_of_residence = context.States.Find(model.State_of_residenceId);
                            query.LGA_of_OriginId = model.LGA_of_OriginId;
                            query.LGA_of_Origin = context.LGAs.Find(model.LGA_of_OriginId);
                            query.State_of_residenceId = model.State_of_residenceId;
                            query.LGA_of_Residence = context.LGAs.Find(model.LGA_of_ResidenceId);
                            query.LGA_of_ResidenceId = model.LGA_of_ResidenceId;
                            query.Correspondence_State = context.States.Find(model.Correspondence_StateId);
                            query.Correspondence_StateId = model.Correspondence_StateId;
                            query.Correspondence_LGA = context.LGAs.Find(model.Correspondence_LGAId);
                            query.Correspondence_LGAId = model.Correspondence_LGAId;
                            query.EMPLOYER_FULLNAME = EmployerDetails_val.NAME;
                            query.Employer_Code = EmployerDetails_val.EMPLOYER_ID;
                            query.EMPLOYER_ADDRESS = EmployerDetails_val.ADDRESS;
                            query.Employer_Building_No = EmployerDetails_val.ADDRESS;
                            query.Employer_State = context.States.Find(model.Employer_StateId);
                            query.Employer_StateId = model.Employer_StateId;
                            query.Employer_LGA = context.LGAs.Find(model.Employer_LGAId);
                            query.Employer_LGAId = model.Employer_LGAId;
                            query.City_of_residence = model.City_of_residence;
                            query.Correspondence_Address = model.Correspondence_Address;
                            query.Correspondence_ZipCode = model.Correspondence_ZipCode;
                            query.Correspondenece_Mobile_No = model.Correspondenece_Mobile_No;
                            query.Employer_Nature_of_Business = model.Employer_Nature_of_Business;
                            query.Employee_IDNO = model.Employee_IDNO;
                            query.EmployeeIPPISNo = model.EmployeeIPPISNo;
                            query.Designation_Rank = model.Designation_Rank;
                            query.Date_of_Transfer_of_Service = model.Date_of_Transfer_of_Service;
                            query.Date_of_retirement = model.Date_of_retirement;
                            query.Date_Of_First_Appointment = model.Date_Of_First_Appointment;
                            query.Date_of_Current_Employment = model.Date_of_Current_Employment;
                            query.DATE_OF_BIRTH = model.DATE_OF_BIRTH;
                            query.DateModified = DateTime.Now;
                            query.DateEmployeeJoinedIPPIS = model.DateEmployeeJoinedIPPIS;
                            query.Current_Step = model.Current_Step;
                            query.Current_Salary_Structure = model.Current_Salary_Structure;
                            query.Current_GL = model.Current_GL;
                            query.Consolidated_Salary_Structure_As_At_2007 = model.Consolidated_Salary_Structure_As_At_2007;
                            query.AGENT_CODE = model.AGENT_CODE;
                            query.Employer_Official_Email = model.Employer_Official_Email;
                            query.Employer_Service_No = model.Employer_Service_No;
                            query.Employer_Zip_Code = model.Employer_Zip_Code;
                            query.Enhanced_Consolidated_Salary_Structure_As_At_2010 = model.Enhanced_Consolidated_Salary_Structure_As_At_2010;
                            query.Enhanced_Consolidated_Salary_Structure_As_At_2013 = model.Enhanced_Consolidated_Salary_Structure_As_At_2013;
                            query.Enhanced_Consolidated_Salary_Structure_As_At_2016 = model.Enhanced_Consolidated_Salary_Structure_As_At_2016;
                            query.FormerPFA1 = model.FormerPFA1;
                            query.FormerPFA2 = model.FormerPFA2;
                            query.FormerPFA3 = model.FormerPFA3;
                            query.FormerPin1 = model.FormerPin1;
                            query.FormerPin2 = model.FormerPin2;
                            query.FormerPin3 = model.FormerPin3;
                            query.GenderId = model.GenderId;
                            query.Gender = context.Genders.Find(model.GenderId);
                            query.GL_As_At_2004 = model.GL_As_At_2004;
                            query.GL_As_At_2007 = model.GL_As_At_2007;
                            query.GL_As_At_2010 = model.GL_As_At_2010;
                            query.GL_As_At_2013 = model.GL_As_At_2013;
                            query.GL_As_At_2016 = model.GL_As_At_2016;
                            query.Harmonized_Salary_Structure_As_At_2004 = model.Harmonized_Salary_Structure_As_At_2004;
                            query.IsEmployerUnderIPPIS = model.IsEmployerUnderIPPIS;
                            query.Step_As_At_2004 = model.Step_As_At_2004;
                            query.Step_As_At_2007 = model.Step_As_At_2007;
                            query.Step_As_At_2010 = model.Step_As_At_2010;
                            query.Step_As_At_2013 = model.Step_As_At_2013;
                            query.Step_As_At_2016 = model.Step_As_At_2016;


                            query.HasAcceptedTnC = model.HasAcceptedTnC;
                            query.IsDetailsCompleted = model.HasAcceptedTnC == true ? true : false;
                            query.AGENT_CODE = model.AGENT_CODE;
                            query.BENEFICIARY_ADDRESS = model.BENEFICIARY_ADDRESS;
                            query.BENEFICIARY_BVN = model.BENEFICIARY_BVN;
                            query.BENEFICIARY_City_of_residence = model.BENEFICIARY_City_of_residence;
                            query.BENEFICIARY_Country_Location = context.Countries.Where(x => x.Value == "Nigeria").FirstOrDefault();
                            query.BENEFICIARY_Country_LocationId = context.Countries.Where(x => x.Value == "Nigeria").FirstOrDefault().Id;
                            query.BENEFICIARY_EMail = model.BENEFICIARY_EMail;
                            query.BENEFICIARY_FIRSTNAME = model.BENEFICIARY_FIRSTNAME;
                            query.Beneficiary_Gender = context.Genders.Find(model.BENEFICIARY_GenderId);
                            query.BENEFICIARY_GenderId = model.BENEFICIARY_GenderId;
                            query.BENEFICIARY_HOME_PHONE = model.BENEFICIARY_HOME_PHONE;
                            query.BENEFICIARY_LGA_of_Residence = context.LGAs.Find(model.BENEFICIARY_LGA_of_ResidenceId);
                            query.BENEFICIARY_LGA_of_ResidenceId = model.BENEFICIARY_LGA_of_ResidenceId;
                            query.BENEFICIARY_MIDDLENAME = model.BENEFICIARY_MIDDLENAME;
                            query.BENEFICIARY_MOBILE_PHONE = model.BENEFICIARY_MOBILE_PHONE;
                            query.BENEFICIARY_NIN = model.BENEFICIARY_NIN;
                            query.BENEFICIARY_OFFICE_PHONE = model.BENEFICIARY_OFFICE_PHONE;
                            query.BENEFICIARY_POBOX = model.BENEFICIARY_POBOX;
                            query.Beneficiary_Relationship = context.Relationships.Find(model.BENEFICIARY_RELATIONSHIPId);
                            query.BENEFICIARY_RELATIONSHIPId = model.BENEFICIARY_RELATIONSHIPId;
                            query.BENEFICIARY_State_of_Residence = context.States.Find(model.BENEFICIARY_State_of_ResidenceId);
                            query.BENEFICIARY_State_of_ResidenceId = model.BENEFICIARY_State_of_ResidenceId;
                            query.BENEFICIARY_SURNAME = model.BENEFICIARY_SURNAME;
                            query.Beneficiary_Title = context.Titles.Find(model.BENEFICIARY_TitleId);
                            query.BENEFICIARY_TitleId = model.BENEFICIARY_TitleId;
                            query.BENEFICIARY_ZIP_CODE = model.BENEFICIARY_ZIP_CODE;

                            query.NOK_ADDRESS = model.NOK_ADDRESS;
                            query.NOK_City_of_residence = model.NOK_City_of_residence;
                            query.NOK_Country_Location = model.NOK_Country_Location;
                            query.NOK_CountryId = context.Countries.Where(x => x.Value == "Nigeria").FirstOrDefault().Id;
                            query.NOK_EMail = model.NOK_EMail;
                            query.NOK_FIRSTNAME = model.NOK_FIRSTNAME;
                            query.NOk_Gender = context.Genders.Find(model.NOK_GenderId);
                            query.NOK_GenderId = model.NOK_GenderId;
                            query.NOK_HOME_PHONE = model.NOK_HOME_PHONE;
                            query.NOK_LGA_of_Residence = context.LGAs.Find(model.NOK_LGA_of_ResidenceId);
                            query.NOK_LGA_of_ResidenceId = model.NOK_LGA_of_ResidenceId;
                            query.NOK_MIDDLENAME = model.NOK_MIDDLENAME;
                            query.NOK_MOBILE_PHONE = model.NOK_MOBILE_PHONE;
                            query.NOK_OFFICE_PHONE = model.NOK_OFFICE_PHONE;
                            query.NOK_POBOX = model.NOK_POBOX;
                            query.NOK_Relationship = context.Relationships.Find(model.NOK_RELATIONSHIPId);
                            query.NOK_RELATIONSHIPId = model.NOK_RELATIONSHIPId;
                            query.NOK_State_of_Residence = context.States.Find(model.NOK_State_of_ResidenceId);
                            query.NOK_State_of_ResidenceId = model.NOK_State_of_ResidenceId;
                            query.NOK_SURNAME = model.NOK_SURNAME;
                            query.NOK_Title = context.Titles.Find(model.NOK_TitleId);
                            query.NOK_TitleId = model.NOK_TitleId;
                            query.NOK_ZIP_CODE = model.NOK_ZIP_CODE;

                            context.SaveChanges();
                            if (model.HasAcceptedTnC == true)
                            {
                                var userData = User.Identity.GetUserName();
                                if (userData.StartsWith("PEN"))
                                {
                                    var user = context.Users.Where(x => x.Email == model.Personal_Email).FirstOrDefault();

                                    await this.UserManager.AddToRoleAsync(user.Id, "RSA Customer");

                                    Logger.DebugFormat($"User with Pin: {model.PIN} has been created successfully and given a customer role.");
                                }
                                else
                                {
                                    var usersData = context.Users.Where(x => x.Email == model.Personal_Email).FirstOrDefault();
                                    if (usersData != null)
                                    {
                                        var Email = model.Personal_Email == "" || model.Personal_Email == null || model.Personal_Email == "PFA@YAHOO.COM" ? $"pfa_{model.PIN}@gmail.com" : model.Personal_Email;

                                        var user = new ApplicationUser { UserName = model.PIN, Email = Email, PhoneNumber = model.Mobile_Phone };
                                        var result2 = await UserManager.CreateAsync(user, "123456");

                                        Logger.DebugFormat($"User with Pin: {model.PIN} has been created successfully.");

                                        await this.UserManager.AddToRoleAsync(user.Id, "RSA Customer");

                                        Logger.DebugFormat($"User with Pin: {model.PIN} has been created successfully and given a customer role.");
                                    }
                                }

                                return RedirectToAction("RecaptureAcknowledgementSlip", "RSA", new { id = model.Id });
                            }
                            else
                            {
                                return RedirectToAction("RecaptureForm");
                            }
                        }
                        else
                        {

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImagePhoto(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Photo_url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageSignature(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Signature_url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageStaffIDCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.StaffIDCard_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageBerthCert(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.BirthCertificate_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageIntlPassport(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Intl_Passport_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageletterOfFirstAppointment(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Letter_of_First_Appointment_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageTransferAndAcceptanceOfService(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.Transfer_Acceptance_of_Service_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageVotersCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.PermanentVotersCard_Url}");

                            //TODO: Saving Staff's Profile Picture
                            model.SavedPostedFileImageNIN(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                    FileNumber);
                            Logger.Debug($"Image creation and saving was successful. {model.NIN_Url}");


                            string pfa_val = Request["PfaName"];
                            long empName_val = Convert.ToInt32(Request["EmpoyerName"]);
                            var PFA_NAME_val = db.PFAs.FirstOrDefault(x => x.PFA_CODE == pfa_val).PFA_NAME;
                            var EmployerDetails_val = db.EMPLOYER_DETAILS.FirstOrDefault(x => x.TRANSID == empName_val);

                            model.EMPLOYER_FULLNAME = EmployerDetails_val.NAME;
                            model.EMPLOYER_ADDRESS = EmployerDetails_val.ADDRESS;
                            model.Employer_Building_No = EmployerDetails_val.ADDRESS;
                            model.Employer_Code = EmployerDetails_val.RCNO;
                            model.NOK_CountryId = 566;
                            model.PFA_Name = PFA_NAME_val;
                            model.SectorClassification = context.SectorClassifications.Find(model.SectorClassificationId);
                            model.Beneficiary_Gender = context.Genders.Find(model.BENEFICIARY_GenderId);
                            model.BENEFICIARY_State_of_Residence = context.States.Find(model.BENEFICIARY_State_of_ResidenceId);
                            model.Beneficiary_Title = context.Titles.Find(model.BENEFICIARY_TitleId);
                            model.Beneficiary_Relationship = context.Relationships.Find(model.BENEFICIARY_RELATIONSHIPId);
                            model.Correspondence_Country = context.Countries.Find(model.Correspondence_CountryId);
                            model.Correspondence_State = context.States.Find(model.Correspondence_StateId);
                            model.Country = context.Countries.Find(model.NATIONALITYId);
                            model.Country_of_residence = context.Countries.Find(model.Country_of_residenceId);
                            model.LGA_of_Origin = context.LGAs.Find(model.LGA_of_OriginId);
                            model.LGA_of_Residence = context.LGAs.Find(model.LGA_of_ResidenceId);
                            model.Correspondence_LGA = context.LGAs.Find(model.Correspondence_LGAId);
                            model.BENEFICIARY_LGA_of_Residence = context.LGAs.Find(model.BENEFICIARY_LGA_of_ResidenceId);
                            model.NOK_LGA_of_Residence = context.LGAs.Find(model.NOK_LGA_of_ResidenceId);
                            model.Employer_Country = context.Countries.Find(model.Employer_CountryId);
                            model.Employer_State = context.States.Find(model.Employer_StateId);
                            model.Gender = context.Genders.Find(model.GenderId);
                            model.MaritalStatus = context.MaritalStatus.Find(model.MARITAL_STATUSId);
                            model.NOk_Gender = context.Genders.Find(model.NOK_GenderId);
                            model.NOK_Relationship = context.Relationships.Find(model.NOK_RELATIONSHIPId);
                            model.NOK_State_of_Residence = context.States.Find(model.NOK_State_of_ResidenceId);
                            model.NOK_Country = context.Countries.Find(566);
                            model.NOK_Title = context.Titles.Find(model.NOK_TitleId);
                            model.RsaStatus = context.RsaStatus.Find(model.RSAStatusId);
                            model.State = context.States.Find(model.STATE_OF_ORIGINId);
                            model.Title = context.Titles.Find(model.TitleId);
                            model.IsDetailsCompleted = model.HasAcceptedTnC == true ? true : false;


                            context.Employees.Add(model);


                            context.SaveChanges();
                            Logger.DebugFormat($"Successful While Saving Recaptured Data.");



                            if (model.HasAcceptedTnC == true)
                            {
                                var userData = User.Identity.GetUserName();
                                if (userData.StartsWith("PEN"))
                                {
                                    var user = context.Users.Where(x => x.Email == model.Personal_Email).FirstOrDefault();

                                    await this.UserManager.AddToRoleAsync(user.Id, "RSA Customer");

                                    Logger.DebugFormat($"User with Pin: {model.PIN} has been created successfully and given a customer role.");
                                }
                                else
                                {
                                    var usersData = context.Users.Where(x => x.Email == model.Personal_Email).FirstOrDefault();
                                    if(usersData != null)
                                    {
                                        var Email = model.Personal_Email == "" || model.Personal_Email == null || model.Personal_Email == "PFA@YAHOO.COM" ? $"pfa_{model.PIN}@gmail.com" : model.Personal_Email;

                                        var user = new ApplicationUser { UserName = model.PIN, Email = Email, PhoneNumber = model.Mobile_Phone };
                                        var result2 = await UserManager.CreateAsync(user, "123456");

                                        Logger.DebugFormat($"User with Pin: {model.PIN} has been created successfully.");

                                        await this.UserManager.AddToRoleAsync(user.Id, "RSA Customer");

                                        Logger.DebugFormat($"User with Pin: {model.PIN} has been created successfully and given a customer role.");
                                    }                              
                                }

                                return RedirectToAction("RecaptureAcknowledgementSlip", "RSA", new { id = model.Id });
                            }
                            else
                            {
                                return RedirectToAction("RecaptureForm");
                            }
                        }



                    }
               }
            }
            catch (Exception ex)
            {
                Logger.DebugFormat($"Error While Saving Recaptured Data ===> {ex}");
                @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
                ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
                ModelState.AddModelError("", "An error occured");
                ViewBag.errorCode2 = 1;
                return View();
            }
            Logger.DebugFormat($"Error While Saving Recaptured Data.");

            @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
            ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
            ModelState.AddModelError("", "An error occured");
            ViewBag.errorCode2 = 1;
            return RedirectToAction("RecaptureAcknowledgementSlip", "RSA", new { id = model.Id });

        }



        public string SaveConsentImage(string ImgStr, string ImgName)
        {
            String path = HttpContext.Server.MapPath($"~/UploadedImages/{ImgName}/"); //Path

            //string path2 = AppDomain.CurrentDomain.BaseDirectory + "UploadedImages\\";
            //Check if directory exist
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
            }

            string imageName = ImgName + "_" + DateTime.UtcNow.ToString("yyyyMMdd_hhmm_") + (new Random().Next(1000, 9999)) + ".jpg";

            //set the image path
            string imgPath = Path.Combine(path, imageName);

            string convert = ImgStr.Replace("data:image/jpeg;base64,", String.Empty);

            byte[] imageBytes = Convert.FromBase64String(convert);

            System.IO.File.WriteAllBytes(imgPath, imageBytes);
            string imagePath = @"/UploadedImages/" + ImgName + "/" + imageName;
            return imagePath;
        }


        public JsonResult GetEmployerDetails(string q)
        {
            Logger.Debug("Compiling data for auto complete...");

            var query = db.EMPLOYER_DETAILS.Where(x => x.NAME.Contains(q)).ToList();


            var rData = query.Select(m => new SelectListItem()
            {
                Text = m.NAME + " " + m.RCNO,
                Value = m.TRANSID.ToString(),
            });
            return Json(query, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetFullEmployerDetails(string id)
        {
            Logger.Debug("Compiling data for auto complete...");
            long queryy = Convert.ToInt32(id);
            var query = db.EMPLOYER_DETAILS.Where(x => x.TRANSID == queryy).FirstOrDefault();


            //var rData = query.Select(m => new SelectListItem()
            //{
            //    Text = m.NAME,
            //    Value = m.TRANSID.ToString(),
            //});
            return Json(query, JsonRequestBehavior.AllowGet);

        }


        [HttpGet]
        public ActionResult RecaptureAcknowledgementSlip(int id)
        {
            var result = context.Employees.Find(id);
            if (result != null)
            {
                return View(result);
            }
            else
            {
                //return HttpNotFound;
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveRecaptureForm(Employee model)
        {
            try
            {
                var fidManager = HttpContext.GetOwinContext().Get<FidManager>();

                if (ModelState.IsValid)
                {
                    var qResult = context.Employees.FirstOrDefault(x => x.PIN == model.RSAPin);
                    if (qResult != null)
                    {
                        ViewBag.RecaptureWarningErrorMsg = $"This Pin: {model.RSAPin} has been recaptured, you can't make any modifications on this again.";
                        @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
                        ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");



                        ViewBag.Hide = 1;
                        return View();
                    }
                    else
                    {
                        var FileNumber = fidManager.GetNewUserFileNumber(); /*"F45HHG778";*/
                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImagePhoto(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageSignature(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageStaffIDCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageBerthCert(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageIntlPassport(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageletterOfFirstAppointment(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageTransferAndAcceptanceOfService(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageVotersCard(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);

                        //TODO: Saving Staff's Profile Picture
                        model.SavedPostedFileImageNIN(WebConfigurationManager.AppSettings["FileBaseDirectory"],
                                FileNumber);




                        model.PIN = model.RSAPin;
                        model.FileNumber = FileNumber;

                        string pfa = Request["PfaName"];
                        var PFA_NAME = db.PFAs.FirstOrDefault(x => x.PFA_CODE == pfa).PFA_NAME;



                        model.PFA_Name = PFA_NAME;
                        model.SectorClassification = context.SectorClassifications.Find(model.SectorClassificationId);
                        model.Beneficiary_Gender = context.Genders.Find(model.BENEFICIARY_GenderId);
                        model.BENEFICIARY_State_of_Residence = context.States.Find(model.BENEFICIARY_State_of_ResidenceId);
                        model.Beneficiary_Title = context.Titles.Find(model.BENEFICIARY_TitleId);
                        model.Beneficiary_Relationship = context.Relationships.Find(model.BENEFICIARY_RELATIONSHIPId);
                        model.Correspondence_Country = context.Countries.Find(model.Correspondence_CountryId);
                        model.Correspondence_State = context.States.Find(model.Correspondence_StateId);
                        model.Country = context.Countries.Find(model.NATIONALITYId);
                        model.Country_of_residence = context.Countries.Find(model.Country_of_residenceId);
                        model.LGA_of_Origin = context.LGAs.Find(model.LGA_of_OriginId);
                        model.LGA_of_Residence = context.LGAs.Find(model.LGA_of_ResidenceId);
                        model.Correspondence_LGA = context.LGAs.Find(model.Correspondence_LGAId);
                        model.BENEFICIARY_LGA_of_Residence = context.LGAs.Find(model.BENEFICIARY_LGA_of_ResidenceId);
                        model.NOK_LGA_of_Residence = context.LGAs.Find(model.NOK_LGA_of_ResidenceId);
                        model.Employer_Country = context.Countries.Find(model.Employer_CountryId);
                        model.Employer_State = context.States.Find(model.Employer_StateId);
                        model.Gender = context.Genders.Find(model.GenderId);
                        model.MaritalStatus = context.MaritalStatus.Find(model.MARITAL_STATUSId);
                        model.NOk_Gender = context.Genders.Find(model.NOK_GenderId);
                        model.NOK_Relationship = context.Relationships.Find(model.NOK_RELATIONSHIPId);
                        model.NOK_State_of_Residence = context.States.Find(model.NOK_State_of_ResidenceId);
                        model.NOK_Title = context.Titles.Find(model.NOK_TitleId);
                        model.RsaStatus = context.RsaStatus.Find(model.RSAStatusId);
                        model.State = context.States.Find(model.STATE_OF_ORIGINId);
                        model.Title = context.Titles.Find(model.TitleId);

                        context.Employees.Add(model);


                        context.SaveChanges();

                    }
                    return RedirectToAction("SaveRecaptureForm", "RSA");
                }
            }
            catch (Exception ex)
            {
                Logger.DebugFormat($"Error While Saving Recaptured Data ===> {ex}");
                @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
                ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
                ModelState.AddModelError("", "An error occured");
                ViewBag.errorCode2 = 1;
                return View();
            }
            @ViewBag.EmpoyerName = new SelectList(db.EMPLOYER_DETAILS.Take(20), "TRANSID", "NAME");
            ViewBag.PfaName = new SelectList(db.PFAs, "PFA_CODE", "PFA_NAME");
            ModelState.AddModelError("", "An error occured");
            ViewBag.errorCode2 = 1;
            return View("SaveRecaptureForm");
        }

        public ActionResult RecapturedList()
        {
            var result = context.Employees.ToList();
            return View(result);
        }


        public JsonResult GetStates(string id)
        {

            //List<SelectListItem> states = new List<SelectListItem>();
            var List = this.GetState(Convert.ToInt32(id));
            var rData = List.Select(m => new SelectListItem()
            {
                Text = m.Value,
                Value = m.Id.ToString(),
            });
            return Json(rData, JsonRequestBehavior.AllowGet);
        }

        // Get State from DB by country ID
        public IList<State> GetState(int id)
        {

            return context.States.Where(x => x.CountryId == id).OrderBy(x => x.Value).ToList();
        }

        public JsonResult GetLGAs(string id)
        {

            //List<SelectListItem> states = new List<SelectListItem>();
            var List = this.GetLGA(Convert.ToInt32(id));
            var rData = List.Select(m => new SelectListItem()
            {
                Text = m.Value,
                Value = m.Id.ToString(),
            });
            return Json(rData, JsonRequestBehavior.AllowGet);
        }

        // Get State from DB by country ID
        public IList<FidelityPension.Models.Core.LGA> GetLGA(int id)
        {
            return context.LGAs.Where(x => x.StateId == id).OrderBy(x => x.Value).ToList();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }

    }
}