using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiLevel3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Clear();
            config.Formatters.Add(new System.Net.Http.Formatting.JsonMediaTypeFormatter());
            // Web API routes
            config.MapHttpAttributeRoutes();
            //config.Formatters.Clear();
            //config.Formatters.Add(new Json)
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
