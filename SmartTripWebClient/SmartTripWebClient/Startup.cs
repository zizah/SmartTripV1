using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartTripWebClient.Startup))]
namespace SmartTripWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
