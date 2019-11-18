using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FidelityPension.Models;
using FidelityPension.Models.DAL;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using FidelityPension.ViewModels;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace FidelityPension.Areas.iPension.Controllers
{
    public class RestClient : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        static HttpClient client = new HttpClient();

        //// GET: api/RestClient
        //public IQueryable<EMPLOYEE> GetEMPLOYEEs()
        //{
        //    return db.EMPLOYEEs;
        //}

        //// GET: api/RestClient/5
        //[ResponseType(typeof(EMPLOYEE))]
        //public IHttpActionResult GetEMPLOYEE(string id)
        //{
        //    EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
        //    if (eMPLOYEE == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(eMPLOYEE);
        //}

        //// PUT: api/RestClient/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutEMPLOYEE(string id, EMPLOYEE eMPLOYEE)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != eMPLOYEE.REGISTRATION_CODE)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(eMPLOYEE).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EMPLOYEEExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/RestClient
        //[ResponseType(typeof(EMPLOYEE))]
        //public IHttpActionResult PostEMPLOYEE(EMPLOYEE eMPLOYEE)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.EMPLOYEEs.Add(eMPLOYEE);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (EMPLOYEEExists(eMPLOYEE.REGISTRATION_CODE))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = eMPLOYEE.REGISTRATION_CODE }, eMPLOYEE);
        //}

        //// DELETE: api/RestClient/5
        //[ResponseType(typeof(EMPLOYEE))]
        //public IHttpActionResult DeleteEMPLOYEE(string id)
        //{
        //    EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
        //    if (eMPLOYEE == null)
        //    {
        //        return NotFound();
        //    }

        //    db.EMPLOYEEs.Remove(eMPLOYEE);
        //    db.SaveChanges();

        //    return Ok(eMPLOYEE);
        //}


        public async Task<ActionResult> GetContributionDetails(CancellationToken cancellationToken)
        {
            string Url = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/MobileRestService.svc/LastFiveTransactionsWeb/PEN100323137466";

            string Url3 = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRestService/MobileRestService.svc/ContributionDetails/pen100323137466/1/2019-01-01/2019-06-01";

            var content3 = await client.GetStringAsync(Url3);

            var data = JsonConvert.DeserializeObject<Root>(content3).ContributionDetailsResult;

            List<ContributionDetailsResultViewModel> vIewModel = new List<ContributionDetailsResultViewModel>();

            for (int i = 0; i < data.Count; i++)
            {
                var model = new ContributionDetailsResultViewModel();

                model.EmployeeContribution = data[i]["EmployeeContribution"].ToString();
                model.EmployerContribution = data[i]["EmployerContribution"].ToString();
                model.Narration = data[i]["Narration"].ToString();
                model.AvcContribution = data[i]["AVCContribution"].ToString();
                model.EmployerName = data[i]["EmployerName"].ToString();
                model.AvcWithdrawal = data[i]["AvcWithdrawal"].ToString();
                model.ContributionDate = data[i]["ContributionDate"].ToString();
                model.Price = data[i]["Price"].ToString();
                model.TotalFee = data[i]["TotalFee"].ToString();
                model.ValueDate = data[i]["ValueDate"].ToString();
                model.Withdrawal = data[i]["Withdrawal"].ToString();
                model.VatFee = data[i]["VatFee"].ToString();

                vIewModel.Add(model);
            }


            //using (var request = new HttpRequestMessage(HttpMethod.Get, Url3))
            //using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
            //{
            //    var stream = await response.Content.ReadAsStreamAsync();

            //    if (response.IsSuccessStatusCode)
            //    {
            //        var dataa = DeserializeJsonFromStream<Root>(stream).LastFiveTransactionsWebResult;
            //        return Json(dataa, JsonRequestBehavior.AllowGet);
            //    }
            //    //  var content = await StreamToStringAsync(stream);

            //}
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private ActionResult Json(List<Dictionary<string, object>> dataa, JsonRequestBehavior allowGet)
        {
            throw new NotImplementedException();
        }


        //public JsonResult GetAllContributionDetails()
        //{
        //    string Url3 = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRestService/MobileRestService.svc/ContributionDetails/pen100323137466/1/2019-01-01/2019-06-01";

        //    var content3 = client.GetStringAsync(Url3);

        //    var data34 = JsonConvert.DeserializeObject<Root>(content3).ContributionDetailsResult;


        //    return Json(data34, JsonRequestBehavior.AllowGet);
        //}

        private async Task<List<Root>> DeserializeOptimizedFromStreamCallAsync(CancellationToken cancellationToken)
        {
            string Url = "http://fpmlwebsvr.fidelitypensionmanagers.com/TheHubRESTService/MobileRestService.svc/LastFiveTransactions/PEN100323137466";

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Get, Url))
            using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
            {
                var stream = await response.Content.ReadAsStreamAsync();

                if (response.IsSuccessStatusCode)
                    return DeserializeJsonFromStream<List<Root>>(stream);

                var content = await StreamToStringAsync(stream);
                throw new ApiException
                {
                    StatusCode = (int)response.StatusCode,
                    Content = content
                };
            }
        }


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


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool EMPLOYEEExists(string id)
        //{
        //    return db.EMPLOYEEs.Count(e => e.REGISTRATION_CODE == id) > 0;
        //}
    }
}