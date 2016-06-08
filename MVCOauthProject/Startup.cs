using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCOauthProject.Startup))]
namespace MVCOauthProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
