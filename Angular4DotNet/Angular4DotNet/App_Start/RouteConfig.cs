﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Angular4DotNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Registration Courses SPA",
                url: "Registration/{*catchall}",
                defaults: new { controller = "Registration", action = "Index" });

            //doing a {*catchall} will not return a 404 if you go to a link that doesn't exist. To avoid that you can do do all separate like below.
            //routes.MapRoute(
            //    name: "Registration Courses SPA",
            //    url: "Registration/Courses",
            //    defaults: new { controller = "Registration", action = "Index" });

            //routes.MapRoute(
            //    name: "Registration Instructors SPA",
            //    url: "Registration/Instructors",
            //    defaults: new { controller = "Registration", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}