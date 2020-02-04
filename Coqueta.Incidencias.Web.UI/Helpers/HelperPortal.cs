using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coqueta.Incidencias.Web.UI
{
    public static class HelperPortal
    {

        public static string MenuActivo(this HtmlHelper html, string permisos, string controller = null, string action = null)
        {
            string activeClass = "active";
            string activeController = (string)html.ViewContext.RouteData.Values["controller"];
            string activeAction = (string)html.ViewContext.RouteData.Values["action"];
            //if (permisos != string.Empty)
            //{
            //    bool tienePermiso = UsuarioTienePermiso(permisos);
            //    if (!tienePermiso)
            //        return "removeMenuOption";
            //}

            return (controller == activeController && action == activeAction) ? activeClass : string.Empty;
        }

    }
}