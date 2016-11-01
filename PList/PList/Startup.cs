using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PList.Startup))]
namespace PList
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
