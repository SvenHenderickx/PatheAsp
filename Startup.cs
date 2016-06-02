using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PatheAsp.Startup))]
namespace PatheAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
