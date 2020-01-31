using Coqueta.Incidencias.Web.Entidades.Dominio.Lotes;
using System.Collections.Generic;

namespace Coqueta.Incidencias.Web.Entidades.Contratos
{
    public interface IRepositorioLotes
    {
        List<Lotes> ObtenerLotes();
    }
}
