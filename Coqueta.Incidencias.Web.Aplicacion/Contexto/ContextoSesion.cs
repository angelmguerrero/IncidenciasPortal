using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Entidades.Dominio.Usuario;

namespace Coqueta.Incidencias.Web.Aplicacion.Contexto
{
    public class ContextoSesion
    {
        public static Usuarios Usuario
        {
            get
            {
                object usuarioSesion = HttpContext.Current.Session["__Usuario__"];
                if (usuarioSesion != null)
                {
                    return (Usuarios)usuarioSesion;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
