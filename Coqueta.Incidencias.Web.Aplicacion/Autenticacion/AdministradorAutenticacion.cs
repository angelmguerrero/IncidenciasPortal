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
            Persona test = repositorioUsuarios.ObtenerUsuarioAutenticado(nombreUsuario, password);
            return EnumeradoAutenticacion.AccesoValido;
        }
        #endregion
    }
}
