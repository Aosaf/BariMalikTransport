using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BariMalikTransport
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Services",
               url: "services",
               defaults: new { controller = "Services", action = "Index", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "AutomobileTransportation",
                url: "services/automobile-transportation",
                defaults: new { controller = "Services", action = "AutomobileTransportation", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "HouseholdGoods",
               url: "services/household-Goods-transportation",
               defaults: new { controller = "Services", action = "HouseholdGoods", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "GeneralCargo",
               url: "services/general-cargo-transportation",
               defaults: new { controller = "Services", action = "GeneralCargo", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "ContainerShifting",
               url: "services/container-shifting",
               defaults: new { controller = "Services", action = "ContainerShifting", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "LocalTruckingServices",
               url: "services/local-trucking-services",
               defaults: new { controller = "Services", action = "ContainerShifting", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "FullContainerLoad",
               url: "services/full-container-load",
               defaults: new { controller = "Services", action = "FullContainerLoad", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
