using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MfpStore.Web.Security
{
    public class AuthHttpModule: IHttpModule
    {
        private void Authenticate(Object source, EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;
            var authentication = DependencyResolver.Current.GetService<IAuthentication>();
            authentication.HttpContext = context;
            context.User = authentication.CurrentUser;
        }

        public void Init(HttpApplication app)
        {
            app.AuthenticateRequest += Authenticate;
        }

        public void Dispose()
        {
        }
    }
}