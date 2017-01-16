using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SmartTripWebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
    name: "SearchHotel",
    url: "Hotel/Search/",
    defaults: new { controller = "Hotel", action = "Search" }
    );


            routes.MapRoute(
           name: "LogOff",
           url: "Compte/LogOff/",
           defaults: new { controller = "Compte", action = "LogOff" }
           );

            routes.MapRoute(
           name: "Login",
           url: "Compte/Login/",
           defaults: new { controller = "Compte", action = "Login" }
           );
            routes.MapRoute(
         name: "LoginHotelier",
         url: "Compte/LoginHotelier/",
         defaults: new { controller = "Compte", action = "LoginHotelier" }
         );
            routes.MapRoute(
            name: "Hotel",
            url: "Hotel/{date}",
            defaults: new { controller = "Hotel", action = "AfficherResultat" },
            constraints: new { date = @"(\d{1,2})-(\d{1,2})-(\d{4})" }
           );
            routes.MapRoute(
           name: "CreerHotel",
           url: "Hotel/Creer/",
           defaults: new { controller = "Hotel", action = "CreerHotel" }
          
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
           
        }
    }
}
