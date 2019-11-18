using FidelityPension.Areas.iPension.viewModels;
using FidelityPension.Models;
using FidelityPension.Models.DAL;
using FidelityPension.ViewModels;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FidelityPension.Areas.iPension.Controllers
{
    public class RSAClientPortalController : Controller
    {
        private readonly ILog Logger = LogManager.GetLogger(typeof(RSAClientPortalController));

        private ApplicationDbContext context = new ApplicationDbContext();
        private PfaDbContext1 db = new PfaDbContext1();

        private static readonly HttpClient client = new HttpClient();

        private readonly RestClient restClient = new RestClient();

        // GET: iPension/RSAClientPortal
        public async Task<ActionResult> Index(CancellationToken cancellationToken)
        {


           // var DataResult = restClient.GetContributionDetails(cancellationToken).Result;

            var userPin = User.Identity.Name;

            string Url = $"http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/MobileRestService.svc/LastFiveTransactionsWeb/{userPin}";

            var content3 = await client.GetStringAsync(Url);

            var data = JsonConvert.DeserializeObject<Root>(content3).LastFiveTransactionsWebResult;

            List<Last5TransactionViewModel> vIewModel = new List<Last5TransactionViewModel>();

            for (int i = 0; i < data.Count; i++)
            {
                var model = new Last5TransactionViewModel();

                model.EmployeeContribution = data[i]["EmployeeContribution"].ToString();
                model.EmployerContribution = data[i]["EmployerContribution"].ToString();
                model.Narration = data[i]["Narration"].ToString();
                model.OtherContribution = data[i]["OtherContribution"].ToString();
                model.ValueDate = data[i]["ValueDate"].ToString();

                vIewModel.Add(model);
            }
            ViewBag.Last5Transaction = vIewModel;

            string Url_Balance = $"http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/MobileRestService.svc/Balance/{userPin}";

            var content_Balance = await client.GetStringAsync(Url_Balance);

            var data_Balance = JsonConvert.DeserializeObject<Root>(content_Balance).BalanceResult;

            ViewBag.RsaBalance = data_Balance["RsaBalance"].ToString();
            ViewBag.VcBalance = data_Balance["VCBalance"] == null ? "₦0.00" : data_Balance["VCBalance"].ToString();

            Logger.DebugFormat($"Process call to get last 5 transaction was succesfull.");


            using (var request = new HttpRequestMessage(HttpMethod.Get, Url))
            using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
            {
                var stream = await response.Content.ReadAsStreamAsync();

                if (response.IsSuccessStatusCode)
                {
                    var dataa = DeserializeJsonFromStream<Root>(stream).LastFiveTransactionsWebResult;
                }
              //  var content = await StreamToStringAsync(stream);
               
            }


            string Url3 = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRestService/MobileRestService.svc/ContributionDetails/pen100323137466/2019-01-01/2019-06-01";

            var contentCDR = await client.GetStringAsync(Url3);

            var dataCDR = JsonConvert.DeserializeObject<Root>(contentCDR).ContributionDetailsResult;

            List<ContributionDetailsResultViewModel> vIewModelCDR = new List<ContributionDetailsResultViewModel>();

            for (int i = 0; i < dataCDR.Count; i++)
            {
                var model = new ContributionDetailsResultViewModel();

                model.EmployeeContribution = dataCDR[i]["EmployeeContribution"].ToString();
                model.EmployerContribution = dataCDR[i]["EmployerContribution"].ToString();
                model.Narration = dataCDR[i]["Narration"].ToString();
                model.AvcContribution = dataCDR[i]["AVCContribution"].ToString();
                model.EmployerName = dataCDR[i]["EmployerName"].ToString();
                model.AvcWithdrawal = dataCDR[i]["AvcWithdrawal"].ToString();
                model.ContributionDate = dataCDR[i]["ContributionDate"].ToString();
                model.Price = dataCDR[i]["Price"].ToString();
                model.TotalFee = dataCDR[i]["TotalFee"].ToString();
                model.ValueDate = dataCDR[i]["ValueDate"].ToString();
                model.Withdrawal = dataCDR[i]["Withdrawal"].ToString();
                model.VatFee = dataCDR[i]["VatFee"].ToString();

                vIewModelCDR.Add(model);
            }

            Session["CntributionDetails"] = vIewModelCDR;

            //  var Data = await DeserializeOptimizedFromStreamCallAsync();
            //var Model = new EmployeeViewModel();

            //string Url = "http://localhost:5000/api/values";

            //using (var request = new HttpRequestMessage(HttpMethod.Get, Url))
            //using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
            //{
            //    var stream = await response.Content.ReadAsStreamAsync();

            //    if (response.IsSuccessStatusCode)
            //        return DeserializeJsonFromStream<List<EmployeeViewModel>>(stream);

            //    var content = await StreamToStringAsync(stream);
            //    throw new ApiException { StatusCode = (int)response.StatusCode, Content = content };
            //}

            return View();
        }

        public ActionResult WelcomeLetter()
        {
            var user = User.Identity.Name;

            var data = db.EMPLOYEES.Where(x => x.PIN == user).FirstOrDefault();
            ViewBag.data = data;
            ViewBag.Pin = user;
            return View();
        }


        public ActionResult AvcSubscription()
        {
            return View();
        }

        public async Task<ActionResult> TransactionHistory()
        {
            string Url3 = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRestService/MobileRestService.svc/ContributionDetails/pen100323137466/2019-01-01/2019-07-01";

            var contentCDR = await client.GetStringAsync(Url3);

            var dataCDR = JsonConvert.DeserializeObject<Root>(contentCDR).ContributionDetailsResult;

            List<ContributionDetailsResultViewModel> vIewModelCDR = new List<ContributionDetailsResultViewModel>();

            for (int i = 0; i < dataCDR.Count; i++)
            {
                var model = new ContributionDetailsResultViewModel();

                model.EmployeeContribution = dataCDR[i]["EmployeeContribution"].ToString();
                model.EmployerContribution = dataCDR[i]["EmployerContribution"].ToString();
                model.Narration = dataCDR[i]["Narration"].ToString();
                model.AvcContribution = dataCDR[i]["AVCContribution"].ToString();
                model.EmployerName = dataCDR[i]["EmployerName"].ToString();
                model.AvcWithdrawal = dataCDR[i]["AvcWithdrawal"].ToString();
                model.ContributionDate = dataCDR[i]["ContributionDate"].ToString();
                model.Price = dataCDR[i]["Price"].ToString();
                model.TotalFee = dataCDR[i]["TotalFee"].ToString();
                model.ValueDate = dataCDR[i]["ValueDate"].ToString();
                model.Withdrawal = dataCDR[i]["Withdrawal"].ToString();
                model.VatFee = dataCDR[i]["VatFee"].ToString();

                vIewModelCDR.Add(model);
            }

            //Session["CntributionDetails"] = vIewModelCDR;
            ViewBag.ContributionDetails = vIewModelCDR;

            return View();
        }

        public ActionResult StatementOfAccount()
        {
            return View();
        }


        public ActionResult BioData(int id)
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

        //private static async Task<List<Root>> DeserializeOptimizedFromStreamCallAsync(CancellationToken cancellationToken)
        //{
        //   string Url = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/MobileRestService.svc/LastFiveTransactions/PEN100323137466";

        //    using (var client = new HttpClient())
        //    using (var request = new HttpRequestMessage(HttpMethod.Get, Url))
        //    using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
        //    {
        //        var stream = await response.Content.ReadAsStreamAsync();

        //        if (response.IsSuccessStatusCode)
        //            return DeserializeJsonFromStream<List<Root>>(stream);

        //        var content = await StreamToStringAsync(stream);
        //        throw new ApiException
        //        {
        //            StatusCode = (int)response.StatusCode,
        //            Content = content
        //        };
        //    }
        //}

        //private static async Task<List<Root>> DeserializeOptimizedFromStreamCallAsync()
        //{
        //   string Url = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/MobileRestService.svc/LastFiveTransactions/PEN100323137466";

        //    var content3 = await client.GetStringAsync(Url);

        //    var data = JsonConvert.DeserializeObject<Root>(content3).LastFiveTransactionsWebResult;

        //    List<Last5TransactionViewModel> vIewModel = new List<Last5TransactionViewModel>();

        //    var model = new Last5TransactionViewModel();

        //    for (int i = 0; i < data.Count; i++)
        //    {
        //        model.EmployeeContribution = data[i]["EmployeeContribution"].ToString();
        //        model.EmployerContribution = data[i]["EmployerContribution"].ToString();
        //        model.ValueDate = data[i]["ValueDate"].ToString();

        //        vIewModel.Add(model);
        //    }


        //    return JsonConvert.DeserializeObject<List<Root>>(content3);


        //    var cancellationToken = new CancellationToken();

        //    using (var request = new HttpRequestMessage(HttpMethod.Get, Url))
        //    using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
        //    {
        //        string jsonstring = JsonConvert.SerializeObject(response);


        //        var stream = await response.Content.ReadAsStreamAsync();

        //        if (response.IsSuccessStatusCode)
        //            return DeserializeJsonFromStream<List<Root>>(stream);

        //        var content = await StreamToStringAsync(stream);
        //        throw new ApiException { StatusCode = (int)response.StatusCode, Content = content };
        //    }
        //}


        private static T DeserializeJsonFromStream<T>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default(T);

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                var jr = new JsonSerializer();
                var searchResult = jr.Deserialize<T>(jtr);
                return searchResult;
            }
        }

        private static async Task<string> StreamToStringAsync(Stream stream)
        {
            string content = null;

            if (stream != null)
            {
                using (var sr = new StreamReader(stream))
                {
                    content = await sr.ReadToEndAsync();
                }
            }

            return content;
        }


        public class ApiException : Exception
        {
            public int StatusCode { get; set; }

            public string Content { get; set; }
        }

    }
}