using CpApi.App_Start;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
[assembly: OwinStartup(typeof(Startup))]
namespace CpApi.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
            app.UseCors(CorsOptions.AllowAll);
            ConfigureAuth(app);
        }
    }
}