using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc2.Startup))]
namespace mvc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
