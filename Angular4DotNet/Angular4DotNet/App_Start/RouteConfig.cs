using System.Web.Mvc;
using System.Web.Routing;

namespace Angular4DotNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //can also do a {*catchall}, but that will not return a 404 if you go to a link that doesn't exist.
            routes.MapRoute(
                name: "Registration Courses SPA",
                url: "Registration/Courses",
                defaults: new { controller = "Registration", action = "Index" });

            routes.MapRoute(
                name: "Registration Instructors SPA",
                url: "Registration/Instructors",
                defaults: new { controller = "Registration", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}