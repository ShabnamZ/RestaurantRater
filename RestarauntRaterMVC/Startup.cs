using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestarauntRaterMVC.Startup))]
namespace RestarauntRaterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
