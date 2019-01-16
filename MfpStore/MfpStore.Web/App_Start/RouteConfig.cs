﻿using MfpStore.App.Constants;
using System.Web.Mvc;
using System.Web.Routing;

namespace MfpStore.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{lang}/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, lang = GlobalConstants.DefaultLang },
                constraints: new { lang = GlobalConstants.Langs }
            );
        }
    }
}
