using System.Web.Mvc;

namespace FidelityPension.Areas.MicroPensionPortal
{
    public class MicroPensionPortalAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MicroPensionPortal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MicroPensionPortal_default",
                "MicroPensionPortal/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}