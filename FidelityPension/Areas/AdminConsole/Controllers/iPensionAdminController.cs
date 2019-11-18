using FidelityPension.Models;
using FidelityPension.Models.Core;
using FidelityPension.Models.DAL;
using log4net;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FidelityPension.Areas.AdminConsole.Controllers
{
    public class iPensionAdminController : Controller
    {
        private readonly ILog Logger = LogManager.GetLogger(typeof(iPensionAdminController));

        private ApplicationDbContext context = new ApplicationDbContext();
        private PfaDbContext1 db = new PfaDbContext1();

        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        //private static RestClient client;

        public iPensionAdminController()
        {
        }

        public iPensionAdminController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
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




        // GET: AdminConsole/iPensionAdmin
        public ActionResult Index()
        {
            return View();
        }
        //public static ExpandoObject ToExpando(this object anonymousObject)
        //{
        //    IDictionary<string, object> anonymousDictionary = new RouteValueDictionary(anonymousObject);
        //    IDictionary<string, object> expando = new ExpandoObject();
        //    foreach (var item in anonymousDictionary)
        //        expando.Add(item);
        //    return (ExpandoObject)expando;
        //}


        public ActionResult RecaptureDataMonitoring()
        {

            dynamic model = new ExpandoObject();
            model.Employee = context.Employees.ToList().GroupBy(x => x.GenderId).Select(g => new { GenderId = g.Key, Count = g.Count() }).OrderBy(x => x.GenderId).ToList();
            var query = context.Employees.ToList().GroupBy(x => x.GenderId).Select(g => new { GenderId = g.Key, Count = g.Count() }).OrderBy(x => x.GenderId);


            List<ExpandoObject> joinData = new List<ExpandoObject>();

            foreach (var item in query)
            {
                IDictionary<string, object> itemExpando = new ExpandoObject();
                foreach (PropertyDescriptor property
                         in
                         TypeDescriptor.GetProperties(item.GetType()))
                {
                    itemExpando.Add(property.Name, property.GetValue(item));
                }
                joinData.Add(itemExpando as ExpandoObject);
            }
            model.JoinData = joinData;

            






          //  dynamic model = new ExpandoObject();
          //  model.Employee = context.Employees.ToList().GroupBy(x => x.GenderId).Select(g => new { GenderId = g.Key, Count = g.Count() }).OrderBy(x => x.GenderId).ToList(); 

          //  //List<Employee> dataSet = context.Employees.ToList();
          ////  var data = context.Employees.ToList().GroupBy(x => x.GenderId).Select(g => new { GenderId = g.Key, Count = g.Count() }).OrderBy(x => x.GenderId).ToList();

          //  //var result = from d in context.Employees
          //  //             group d by d.GenderId into grouping

          //  ViewBag.data = model;

            return View(model);
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