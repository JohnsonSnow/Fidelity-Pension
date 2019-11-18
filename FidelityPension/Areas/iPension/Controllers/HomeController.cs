using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FidelityPension.Areas.iPension.Controllers
{
    public class HomeController : Controller
    {
        // GET: iPension/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}