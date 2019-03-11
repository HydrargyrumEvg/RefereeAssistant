using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITU.RefereeAssistant.Web.Startup))]
namespace ITU.RefereeAssistant.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
