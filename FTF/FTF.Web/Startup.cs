using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FTF.Web.Startup))]
namespace FTF.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
