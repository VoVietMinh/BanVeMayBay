using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectBanNuoc.Startup))]
namespace ProjectBanNuoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
