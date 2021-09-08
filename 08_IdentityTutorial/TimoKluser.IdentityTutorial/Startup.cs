using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimoKluser.IdentityTutorial.Startup))]
namespace TimoKluser.IdentityTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
