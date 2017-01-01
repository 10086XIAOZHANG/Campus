using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CpApi.App_Start
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            /*
              app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions
             {
                 TokenEndpointPath = new PathString("/token"),
                 Provider = new ApplicationOAuthProvider(),
                 AccessTokenExpireTimeSpan = TimeSpan.FromHours(2),
                 AuthenticationMode = AuthenticationMode.Active,
                 //HTTPS is allowed only AllowInsecureHttp = false
                 AllowInsecureHttp = true
                 //ApplicationCanDisplayErrors = false
             });
             app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
             */
            app.UseOAuthBearerTokens(new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new ApplicationOAuthProvider(),
                //RefreshTokenProvider = new ApplicationRefreshTokenProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(2),
                AuthenticationMode = AuthenticationMode.Active,
                //HTTPS is allowed only AllowInsecureHttp = false
                AllowInsecureHttp = true
                //ApplicationCanDisplayErrors = false
            });
        }
    }
}