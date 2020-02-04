using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias;

namespace Coqueta.Incidencias.Web.Aplicacion.Incidencias
{
    public interface IAdministradorIncidencias
    {
        List<TipoIncidencias> ObtenerTipoIncidencias();
    }
}
