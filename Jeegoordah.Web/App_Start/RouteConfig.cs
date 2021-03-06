﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Jeegoordah.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region Events

            routes.MapRoute(
                name: "UpdateEvent",
                url: "events/update",
                defaults: new { controller = "Events", action = "Update" }
            );
            routes.MapRoute(
                name: "DeleteEvent",
                url: "events/delete/{id}",
                defaults: new { controller = "Events", action = "Delete" }
            );
            routes.MapRoute(
                name: "CreateEvent",
                url: "events/create",
                defaults: new { controller = "Events", action = "Create" }
            );
            routes.MapRoute(
                name: "ListEvents",
                url: "events",
                defaults: new { controller = "Events", action = "List" }
            );

            #endregion


            routes.MapRoute(
                name: "ListBros",
                url: "bros",
                defaults: new { controller = "Bros", action = "List" }
            );

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "General", action = "Index" }
            );

#if DEBUG
            routes.MapRoute(
                name: "ClearDatabase",
                url: "test/cleardatabase",
                defaults: new { controller = "Test", action = "ClearDatabase" }
            );
#endif
        }
    }
}