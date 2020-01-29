using Coqueta.Incidencias.Web.Entidades.Dominio.Usuario;

namespace Coqueta.Incidencias.Web.Entidades.Contratos
{
    public interface IRepositorioUsuarios
    {
        Usuarios ObtenerUsuarioAutenticado(string nombreUsuario, string password);
    }
}
