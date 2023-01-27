using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(login_regV2.Startup))]
namespace login_regV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
