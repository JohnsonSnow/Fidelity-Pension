using FidelityPension.Models;
using log4net;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace FidelityPension.Utility
{
    public class FidManager : IDisposable
    {
        //FidManager, a utility factory/singleton manager
        //That can be used for configuration and all
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FidManager));
        private static FidManager fidManager { get; set; }
        private static PasswordValidator PasswordValidator { get; set; }
        private ApplicationDbContext ApplicationDbContext { get; set; }
        private bool IsProduction { get; set; }




        public static FidManager Builder()
        {
            var FIDManager = fidManager ?? (fidManager = new FidManager());
            FIDManager.ApplicationDbContext = new ApplicationDbContext();
            return FIDManager;
        }

        public static IEnumerable<SelectListItem> Gender()
        {
            var list = new List<SelectListItem>()
            {

                //new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Male", Value = "Male"},
                new SelectListItem {Text = "Female", Value = "Female"}
            };
            return list;
        }



        public static IEnumerable<SelectListItem> MaritalStatus()
        {
            var list = new List<SelectListItem>()
            {
               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Married", Value = "MD"},
                new SelectListItem {Text = "Single", Value = "SG"},
                new SelectListItem {Text = "Divorced", Value = "DV"},
                new SelectListItem {Text = "Widowed", Value = "WD"},
                new SelectListItem {Text = "Separated", Value = "SP"}
            };
            return list;
        }

        public static IEnumerable<SelectListItem> Title()
        {
            var list = new List<SelectListItem>()
            {

               // new SelectListItem {Text = "-- Select Option --", Value = ""},
                new SelectListItem {Text = "Mr", Value = "Mr"},
                new SelectListItem {Text = "Mrs", Value = "Mrs"},
                new SelectListItem {Text = "Miss", Value = "Miss"},
                new SelectListItem {Text = "Ms", Value = "Ms"}
            };
            return list;
        }

        public FidManager SetProduction(bool IsProduction)
        {
            this.IsProduction = IsProduction;
            return this;
        }

        public FidManager SetProduction()
        {
            IsProduction = bool.Parse(ConfigurationManager.AppSettings["kys:IsProduction"]);

            return this;
        }

        public bool GetProduction()
        {
            return IsProduction;
        }

        public PasswordValidator GetPasswordValidator()
        {
            return PasswordValidator ?? (PasswordValidator = new PasswordValidator
            {
                RequiredLength = (IsProduction ? GetMaxmimumPasswordLength() : GetMinimumPasswordLength()),
                RequireNonLetterOrDigit = IsProduction,
                RequireDigit = IsProduction,
                RequireLowercase = IsProduction,
                RequireUppercase = IsProduction,
            });
        }

        public string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ2345678923456789234567892345678923456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GetNewUserFileNumber()
        {
            Random random = new Random();
            int randomCharLength = 4;
            DateTime now = DateTime.UtcNow;

            int totalYearsFromEpoch = now.Year - 2013;
            string fileNumberPrefix = GetYearIndicator(totalYearsFromEpoch < 1 ? 1 : totalYearsFromEpoch);
            string fileNumber = "";

            // Hack to ensure there are approximately the same number of digits as alphabets
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ2345678923456789234567892345678923456789";
            do
            {
                fileNumber =
                    fileNumberPrefix +
                    now.ToString("MMdd") +
                    new string(Enumerable.Repeat(chars, randomCharLength)
                        .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (new ApplicationDbContext().Users.FirstOrDefault(x => x.FileNumber == fileNumber) != null);
            return fileNumber;
        }

        static string GetYearIndicator(int columnNumber)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = letters[modulo].ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        public int GetMinimumPasswordLength()
        {
            var minPasswordLength = int.Parse(ConfigurationManager.AppSettings["kys:minimumPasswordLength"]);
            return minPasswordLength;
        }

        public int GetMaxmimumPasswordLength()
        {
            var maxPasswordLength = int.Parse(ConfigurationManager.AppSettings["kys:maximumPasswordLength"]);
            return maxPasswordLength;
        }

        public bool GetUserLockOutEnabled()
        {
            return bool.Parse(ConfigurationManager.AppSettings["kys:UserLockedOutEnabled"]);
        }

        public int GetUserLockOutTime()
        {
            return int.Parse(ConfigurationManager.AppSettings["kys:UserLockedOutTime"]);
        }

        public int GetMaxFailedAccessAttemptsBeforeLockout()
        {
            return int.Parse(ConfigurationManager.AppSettings["kys:MaxFailedAccessAttemptsBeforeLockout"]);
        }

        //public string ComposeEmailTemplateForUserRegistration(string userEmail, string fullName, string password, string fileNumber, string estateEmail, string estatePhoneNumber, string estateName)
        //{
        //    Logger.DebugFormat($"Start Generating Template String...");
        //    var photoUrl = FidManager.Builder().GetEstateProfile();
        //    var baseUrl = WebConfigurationManager.AppSettings["base_url"];
        //    var loginUrl = WebConfigurationManager.AppSettings["base_login_url"];

        //    var contentReplacements = new Dictionary<string, string>
        //    {
        //        {"{{loginUrl}}", loginUrl ?? "" },
        //        {"{{EstatePhoto}}", baseUrl + photoUrl ?? ""},
        //        {"{{fullName}}", fullName },
        //        {"{{userEmail}}",  userEmail},
        //        {"{{password}}", password},
        //        {"{{fileNumber}}", fileNumber},
        //        {"{{estateEmail}}", estateEmail },
        //        {"{{estatePhoneNumber}}", estatePhoneNumber },
        //        {"{{estateName}}", estateName }
        //    };

        //    var emailHtmlContent = System.IO.File.ReadAllText(GetUserAccountCreateTemplateWithPassword());

        //    Logger.DebugFormat($"Completed Generating Template String For ===> {fullName}");

        //    return contentReplacements.Aggregate(emailHtmlContent,
        //        (current, pair) => current.Replace(pair.Key, pair.Value));
        //}

        //public string GetOtherUserAccountCreateTemplateWithPassword()
        //{
        //    return ConfigurationManager.AppSettings["emailTemplateCreateOtherUserAccount"];
        //}













        public void Dispose()
        {
        }
    }
}