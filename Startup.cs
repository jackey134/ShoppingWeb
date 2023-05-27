using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFinalProj.Startup))]
namespace WebFinalProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
