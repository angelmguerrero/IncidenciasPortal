using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Entidades.Dominio.Usuario;
using Coqueta.Incidencias.Web.Datos.Contexto;

namespace Coqueta.Incidencias.Web.Datos.Repositorio
{
    //public class RepositorioUsuario : Repositorio<Usuario>, IRepositorioUsuarios
    public class RepositorioUsuario : IRepositorioUsuarios
    {

        private string cadenaConexion;

        #region Constructor
        public RepositorioUsuario(string cadenaConexion)
        {
            this.cadenaConexion =cadenaConexion;
        }
        #endregion


        #region Métodos Públicos
        Persona IRepositorioUsuarios.ObtenerUsuarioAutenticado(string nombreUsuario, string password)
        {
            
            ModeloDatos objEntity = new ModeloDatos(cadenaConexion);
            List<Usuario> lstUser = new List<Usuario>();
            lstUser = objEntity.Usuarios.ToList();
            
            var query = from US in lstUser
            where US.NombreUsuario == nombreUsuario && US.Password == password && Convert.ToBoolean(US.Activo)
                        select new Persona()
                        {
                            Id = US.Id,
                            Nombre = US.Nombre,
                            NombreUsuario = US.NombreUsuario,
                            Password = US.Password
                        };

            Persona usuario = query.SingleOrDefault();

            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                return null;
            }
        }
        #endregion}

    }
}
