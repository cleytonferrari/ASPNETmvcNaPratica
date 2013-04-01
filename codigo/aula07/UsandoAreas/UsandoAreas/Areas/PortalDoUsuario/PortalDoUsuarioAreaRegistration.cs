using System.Web.Mvc;

namespace UsandoAreas.Areas.PortalDoUsuario
{
    public class PortalDoUsuarioAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PortalDoUsuario";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PortalDoUsuario_default",
                "PortalDoUsuario/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
