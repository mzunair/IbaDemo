using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IBADemoApp.Startup))]
namespace IBADemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
