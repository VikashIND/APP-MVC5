using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_APP.Startup))]
namespace MVC5_APP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
