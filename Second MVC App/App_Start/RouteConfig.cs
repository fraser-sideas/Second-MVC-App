using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Second_MVC_App.Controllers;

namespace Second_MVC_App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Albums by Release Date",
                "albums/released/{year}/{month}",
                new {controller = "Albums", action = "ByReleaseDate"},
                new {year = @"\d{4}", month = @"\d{2}"}
               );
                

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
