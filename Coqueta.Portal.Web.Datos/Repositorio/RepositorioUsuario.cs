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
    public class RepositorioUsuario : IRepositorioUsuarios
    {
        public string cadenaConexion;
        ModeloDatos db;

        #region Constructor
        public RepositorioUsuario(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            this.db = new ModeloDatos(cadenaConexion);
        }
        #endregion
        
        #region Métodos Públicos
        Usuario IRepositorioUsuarios.ObtenerUsuarioAutenticado(string nombreUsuario, string password)
        {
         
                var obj = db.Usuarios.Where(a => a.NombreUsuario.Equals(nombreUsuario) && a.Password.Equals(password) && a.Activo == true).FirstOrDefault();

                if (obj != null)
                {
                    Usuario user = new Usuario();
                    user.Id = obj.Id;
                    user.Nombre = obj.Nombre;
                    user.NombreUsuario = obj.NombreUsuario;
                    return user;
                }
                else
                    return null;
            



        }
        #endregion
    }

}
