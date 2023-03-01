using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebManagementSystem.Startup))]
namespace WebManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
