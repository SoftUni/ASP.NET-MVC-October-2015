using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaptopStore.App.Startup))]
namespace LaptopStore.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
