using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstExample.Startup))]
namespace FirstExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
