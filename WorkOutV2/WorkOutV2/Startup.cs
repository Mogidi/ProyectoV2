using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkOutV2.Startup))]
namespace WorkOutV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
