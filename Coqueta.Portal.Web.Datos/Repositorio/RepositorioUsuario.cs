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
        private string cadenaConexion;

        #region Constructor
        public RepositorioUsuario(string cadenaConexion)
        {
            this.cadenaConexion =cadenaConexion;
        }
        #endregion


        #region Métodos Públicos
        Usuarios IRepositorioUsuarios.ObtenerUsuarioAutenticado(string nombreUsuario, string password)
        {

            using (ModeloDatos db = new ModeloDatos(cadenaConexion))
            {
                var obj = db.Usuarios.Where(a => a.NombreUsuario.Equals(nombreUsuario) && a.Password.Equals(password) && a.Activo == true).FirstOrDefault();

                if (obj != null)
                {
                    Usuarios user = new Usuarios();
                    user.Id = obj.Id;
                    user.Nombre = obj.Nombre;
                    user.NombreUsuario = obj.NombreUsuario;
                    return user;


                    //Session["products"] = user.Nombre;
                }
                else
                    return null;

            }
          
        }
        #endregion}

    }
}
