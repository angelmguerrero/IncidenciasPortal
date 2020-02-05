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
        public static string Usuario
        {
            get
            {
                object usuarioSesion = HttpContext.Current.Session[ConstanteSesion.Usuario];
                if (usuarioSesion != null)
                {
                    string usrtmp = usuarioSesion.ToString();
                    return usrtmp;
                }
                else
                {
                    return null;
                }
            }
        }

        public static int UsuarioID
        {
            get
            {
                object usuarioSesion = HttpContext.Current.Session[ConstanteSesion.UsuarioId];
                if (usuarioSesion != null)
                {
                    int usrtmp = int.Parse(usuarioSesion.ToString());
                    return usrtmp;
                }
                else
                {
                    return 0;
                }
            }
        }


        public static void AgregarSession(string NombreSession, string valorSession)
        {
            HttpContext.Current.Session[NombreSession] = valorSession;
        }


    }
}
