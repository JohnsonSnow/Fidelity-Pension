using System.Web.Mvc;

namespace FidelityPension.Areas.AdminConsole
{
    public class AdminConsoleAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminConsole";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminConsole_default",
                "AdminConsole/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}