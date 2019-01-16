using System.Web.Mvc;
using System.Web.Routing;

namespace MfpStore.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            const string lang = "RU";
            const string langs = "RU|EN|UK";

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{lang}/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, lang },
                constraints: new { lang = langs }
            );
        }
    }
}
