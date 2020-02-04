using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trialApp.Startup))]
namespace trialApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
