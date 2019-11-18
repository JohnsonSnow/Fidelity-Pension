using FidelityPension.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FidelityPension.Controllers
{
    [RequireHttps]
    public class HomeController : MyController
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<ActionResult> Index()
        {

            ViewBag.FundI = "1.0510";
            ViewBag.FundII = "2.9869";
            ViewBag.FundIII = "1.1312";
            ViewBag.FundIV = "3.0652";

            //string Url = $"http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/MobileRestService.svc/GetFundPrice";

            //var content3 = await client.GetStringAsync(Url);


            //Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(content3);

            //foreach (var i in data)
            //{
            //    if(i.Key == "FundI")
            //    {
            //        ViewBag.FundI = i.Value;

            //    }else if (i.Key == "FundII")
            //    {
            //        ViewBag.FundII = i.Value;
            //    }
            //    else if (i.Key == "FundIII")
            //    {
            //        ViewBag.FundIII = i.Value;
            //    }
            //    else if (i.Key == "FundIV")
            //    {
            //        ViewBag.FundIV = i.Value;
            //    }
            //    else if (i.Value == "FundV")
            //    {

            //    }
            //    else
            //    {

            //    }
            //}
            //// ViewBag.FundI = data[0].value;

            //ViewBag.Last5Transaction = data;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BoardOfDirectors()
        {


            return View();
        }

        public ActionResult CorporateGovernance()
        {


            return View();
        }
        public ActionResult ManagementTeam()
        {


            return View();
        }
        public ActionResult VoluntaryContribution()
        {


            return View();
        }
        public ActionResult MicroPension()
        {


            return View();
        }
        public ActionResult Nsitf()
        {


            return View();
        }
        public ActionResult CrossBorderPension()
        {


            return View();
        }
        public ActionResult RetirementAdvisioryServices()
        {


            return View();
        }
        public ActionResult ProgrammedWithdrawal()
        {


            return View();
        }
        public ActionResult TemporaryAccessToRSA()
        {


            return View();
        }
        public ActionResult MultiFunds()
        {


            return View();
        }
        public ActionResult InvestmentPortfolio()
        {


            return View();
        }
        public ActionResult FidApp()
        {


            return View();
        }
        public ActionResult Careers()
        {


            return View();
        }
        public ActionResult DropAMessage()
        {


            return View();
        }
        public ActionResult FAQ()
        {


            return View();
        }
        public ActionResult NewsLetter()
        {


            return View();
        }
        public ActionResult ImageGallery()
        {


            return View();
        }
        public ActionResult RetirementSavingsAccount()
        {


            return View();
        }

        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageManager().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
        }
    }
}