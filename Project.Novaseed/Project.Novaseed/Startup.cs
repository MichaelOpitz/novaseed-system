using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project.Novaseed.Startup))]
namespace Project.Novaseed
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
