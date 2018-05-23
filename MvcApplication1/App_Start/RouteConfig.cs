using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Principal", action = "Bienvenido" }
            );

            routes.MapRoute(
               name: "Principal",
               url: "Principal/Bienvenido",
               defaults: new { controller = "Principal", action = "Bienvenido" }
           );

            routes.MapRoute(
                name: "Calculadora",
                url: "{controller}/{action}",
                defaults: new { controller = "Calculadora"}
            );

        }
    }
}