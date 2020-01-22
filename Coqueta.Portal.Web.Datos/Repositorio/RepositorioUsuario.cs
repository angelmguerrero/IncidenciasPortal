using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Portal.Web.Entidades.Contratos;
using Coqueta.Portal.Web.Entidades.Dominio.Usuario;
//using Coqueta.Core.UoW;
using Coqueta.Portal.Web.Datos.Contexto;
using Modelo = Coqueta.Portal.Web.Datos.Contexto;

namespace Coqueta.Portal.Web.Datos.Repositorio
{
    //public class RepositorioUsuario : Repositorio<Usuario>, IRepositorioUsuarios
    public class RepositorioUsuario : IRepositorioUsuarios
    {

        public RepositorioUsuario()
           
        {
        }


        Persona IRepositorioUsuarios.ObtenerUsuarioAutenticado(string nombreUsuario, string password)
        {
            ModeloDatos objEntity = new ModeloDatos();
            List<Usuario> lstUser = new List<Usuario>();
            lstUser = objEntity.Usuarios.ToList();

            var query = from US in objEntity.Usuarios
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


    }
}
