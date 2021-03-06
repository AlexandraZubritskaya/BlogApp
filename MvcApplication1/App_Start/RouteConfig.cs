﻿using System;
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

            routes.MapRoute("Post", "post-{title}", new { controller = "Home", action = "Index" });

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
              );
            //public static readonly string[] Namespaces = new[] {"MvcApplication1.Controllers"};
            /* public static void RegisterRoutes(RouteCollection routes)
             {
                 routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                 routes.MapRoute(
                     name: "article",
                     url: "{article}-{seoURL}",
                     defaults: new { controller = "Comment", action = "GetByUrl", seoUrl = string.Empty }
               
                
                     );
                 routes.MapRoute(
                   name: "Default",
                   url: "{controller}/{action}/{id}",
                   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                   , namespaces: Namespaces
                   );
               
             }*/
        }
        
    }
}