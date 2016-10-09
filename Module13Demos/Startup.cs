using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Module13Demos.Startup))]
namespace Module13Demos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Microsoft.AspNet.SignalR.StockTicker.Startup.ConfigureSignalR(app);

        }
    }
}
