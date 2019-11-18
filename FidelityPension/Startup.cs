using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FidelityPension.Startup))]
namespace FidelityPension
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
