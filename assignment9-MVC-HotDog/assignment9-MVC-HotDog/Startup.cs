using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment9_MVC_HotDog.Startup))]
namespace assignment9_MVC_HotDog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
