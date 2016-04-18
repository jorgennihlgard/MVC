using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
           name: "self",
           url: "self/{action}/{id}",
           defaults: new { controller = "Self", action = "B2B", id = UrlParameter.Optional }
       );

            routes.MapRoute(
                name: "Life",
                url: "Life/{action}/{id}",
                defaults: new { controller = "Life", action = "SuperMario", id = UrlParameter.Optional }
            );

            routes.MapRoute(
             name: "Laser",
             url: "Laser/{action}/{id}",
             defaults: new { controller = "Laser", action = "Sabel", id = UrlParameter.Optional }
         );

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );

        }
    }
}
