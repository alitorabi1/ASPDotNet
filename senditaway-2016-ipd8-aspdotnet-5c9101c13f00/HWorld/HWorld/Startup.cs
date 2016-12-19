using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HWorld.Startup))]
namespace HWorld
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
