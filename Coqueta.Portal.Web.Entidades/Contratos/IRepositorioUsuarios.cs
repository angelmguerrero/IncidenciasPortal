using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Dominio.Usuario;

namespace Coqueta.Incidencias.Web.Entidades.Contratos
{
    public interface IRepositorioUsuarios
    {
        Persona ObtenerUsuarioAutenticado(string nombreUsuario, string password);
    }
}
