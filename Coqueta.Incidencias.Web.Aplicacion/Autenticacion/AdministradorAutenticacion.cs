using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Datos.Repositorio;
using Coqueta.Incidencias.Web.Datos.Contexto;
using Coqueta.Incidencias.Web.Entidades.Dominio.Usuario;
using System.Web.Security;
using Coqueta.Incidencias.Web.Aplicacion.Contexto;

namespace Coqueta.Incidencias.Web.Aplicacion.Autenticacion
{
    public class AdministradorAutenticacion: IAdministradorAutenticacion
    {
        #region Campos
        private string cadenaConexion;
        #endregion

        #region Constructores
        public AdministradorAutenticacion(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        #endregion


        #region Métodos Públicos
        EnumeradoAutenticacion IAdministradorAutenticacion.AutenticarUsuario(string nombreUsuario, string password)
        {
            

            IRepositorioUsuarios repositorioUsuarios = new RepositorioUsuario(cadenaConexion);
            Usuario Usuario = repositorioUsuarios.ObtenerUsuarioAutenticado(nombreUsuario, password);

            if (Usuario != null)
            {
                FormsAuthentication.SetAuthCookie(Usuario.Nombre, false);
                ContextoSesion.PersistirUsuario(Usuario.Nombre);

                return EnumeradoAutenticacion.AccesoValido;

            }
            else
                return EnumeradoAutenticacion.CredencialesInvalidas;
        }
        #endregion
    }
}
