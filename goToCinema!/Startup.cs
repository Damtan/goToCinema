using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(goToCinema_.Startup))]
namespace goToCinema_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
