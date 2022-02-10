using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenuWebApp.Startup))]
namespace MenuWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
