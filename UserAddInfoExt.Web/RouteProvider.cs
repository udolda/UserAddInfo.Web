using System.Collections.Generic;
using System.Web.Mvc;
using Orchard.Mvc.Routes;
using System.Web.Routing;

namespace UserAddInfoExt.Web
{
    public class RouteProvider : IRouteProvider
    {
        public const string AreaName = "UserAddInfoExt.Web";

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                             new RouteDescriptor {
                                                     Priority = 20,
                                                     Route = new Route(
                                                         "UserAddInfoExt.Web/{controller}/{action}/{id}",
                                                         new RouteValueDictionary {
                                                                                      {"area", AreaName},
                                                                                      {"controller", "Home"},
                                                                                      {"action", "Index"},
                                                                                      {"id", UrlParameter.Optional}
                                                                                  },
                                                         null,
                                                         new RouteValueDictionary
                                                             {
                                                                 {"area", AreaName}
                                                             },
                                                         new MvcRouteHandler())
                                                 }
                         };
        }
    }
}