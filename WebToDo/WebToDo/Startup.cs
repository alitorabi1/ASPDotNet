using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebToDo.Startup))]
namespace WebToDo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
