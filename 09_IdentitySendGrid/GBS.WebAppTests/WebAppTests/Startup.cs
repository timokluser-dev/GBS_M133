using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTests.Startup))]
namespace WebAppTests
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
