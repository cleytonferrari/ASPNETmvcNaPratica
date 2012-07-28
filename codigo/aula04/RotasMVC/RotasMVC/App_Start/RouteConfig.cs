using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace RotasMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "noticias/",
                defaults: new { controller = "Home", action = "TodasAsNoticias" }
                );

            routes.MapRoute(
                name: "Categoria Especifica",
                url: "noticias/{categoria}",
                defaults: new { controller = "Home", action = "MostraCategoria" }
                );

            routes.MapRoute(
                name: "Mostra Noticia",
                url: "noticias/{categoria}/{titulo}-{noticiaId}",
                defaults: new { controller = "Home", action = "MostraNoticia" }
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}