using Coqueta.Incidencias.Web.Comun.Constantes;
using System.Web;

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
