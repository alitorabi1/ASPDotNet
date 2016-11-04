using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quiz1Customers.Startup))]
namespace Quiz1Customers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
