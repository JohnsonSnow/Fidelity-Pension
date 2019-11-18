using System.Web.Mvc;

namespace FidelityPension.Areas.iPension
{
    public class iPensionAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "iPension";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "iPension_default",
                "iPension/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "FidelityPension.Areas.iPension.Controllers" }
            );
        }
    }
}