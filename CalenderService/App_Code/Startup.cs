using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalenderService.Startup))]
namespace CalenderService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
