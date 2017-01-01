using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace CpApi
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        /*
       private OAuth2ClientService _oauthClientService;
       public ApplicationOAuthProvider()
       {
           this.OAuth2ClientService = new OAuth2ClientService();
       }
       */

        /// <summary>
        /// 验证客户[client_id与client_secret验证]
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            //http://localhost:48339/token
            //grant_type=client_credentials&client_id=irving&client_secret=123456
            string client_id;
            string client_secret;
            context.TryGetFormCredentials(out client_id, out client_secret);
            if (client_id == "irving" && client_secret == "123456")
            {
                context.Validated(client_id);
            }
            else
            {
                //context.Response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                context.SetError("invalid_client", "client is not valid");
            }
            return base.ValidateClientAuthentication(context);
        }

        /// <summary>
        /// 客户端授权[生成access token]
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        {
            /*
                 var client = _oauthClientService.GetClient(context.ClientId);
                 oAuthIdentity.AddClaim(new Claim(ClaimTypes.Name, client.ClientName));
             */


            //var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
            //oAuthIdentity.AddClaim(new Claim(ClaimTypes.Name, "iphone"));
            //var ticket = new AuthenticationTicket(oAuthIdentity, new AuthenticationProperties() { AllowRefresh = true });
            //context.Validated(ticket);
            //return base.GrantClientCredentials(context);
            var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
            oAuthIdentity.AddClaim(new Claim(ClaimTypes.Name, "iphone"));
            //可以加入用户信息及其他必要信息到Token中，以便在api服务中使用(使用中HttpContext.Current.User.Identity即为oAuthIdentity对象，WebApi的Controller中可直接使用User.Identity)。
            oAuthIdentity.AddClaim(new Claim("UserID", "irving"));
            var ticket = new AuthenticationTicket(oAuthIdentity, new AuthenticationProperties());
            context.Validated(ticket);//认证通过
            return base.GrantClientCredentials(context);
        }

        /// <summary>
        /// 刷新Token[刷新refresh_token]
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            //enforce client binding of refresh token
            if (context.Ticket == null || context.Ticket.Identity == null || !context.Ticket.Identity.IsAuthenticated)
            {
                context.SetError("invalid_grant", "Refresh token is not valid");
            }
            else
            {
                //Additional claim is needed to separate access token updating from authentication 
                //requests in RefreshTokenProvider.CreateAsync() method
            }
            return base.GrantRefreshToken(context);
        }

        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == "irving")
            {
                var expectedRootUri = new Uri(context.Request.Uri, "/");
                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }
            return Task.FromResult<object>(null);
        }
    }
}