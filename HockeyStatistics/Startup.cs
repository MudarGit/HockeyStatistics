using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HockeyStatistics.Startup))]
namespace HockeyStatistics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
