using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MfpStore.Web.Controllers
{
    public class BaseController : Controller
    {
        private string CurrentLang { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            var lang = requestContext.RouteData.Values["lang"];

            if (lang != null && lang as string != "null")
            {
                CurrentLang = lang as string;
                var currentCultureInfo = new CultureInfo(CurrentLang);
                Thread.CurrentThread.CurrentUICulture = currentCultureInfo;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(currentCultureInfo.Name);
            }

            base.Initialize(requestContext);
        }
    }
}