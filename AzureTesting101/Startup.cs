using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureTesting101.Startup))]
namespace AzureTesting101
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
