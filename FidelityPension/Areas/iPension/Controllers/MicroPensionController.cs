using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FidelityPension.Areas.iPension.Controllers
{
    public class MicroPensionController : Controller
    {
        // GET: iPension/MicroPension
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrationForm()
        {
            return View();
        }
    }
}