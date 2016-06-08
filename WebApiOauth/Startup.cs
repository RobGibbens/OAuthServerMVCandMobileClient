using System;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using WebApiOauth;

[assembly: OwinStartup(typeof(Startup))]
namespace WebApiOauth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            //throw new NotImplementedException();
            ConfigureAuth(app);
        }

        private void ConfigureAuth(IAppBuilder app)
        {
            //app.Use(async (context, next) =>
            //{
            //    var token = HttpUtility.ParseQueryString(context.Request.QueryString.Value).Get("access_token");

            //    if (! string.IsNullOrWhiteSpace(token))
            //        context.Request.Headers.Add("Authorization", new []{ $"Bearer {token}"});

            //    await next.Invoke();
            //});

            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
