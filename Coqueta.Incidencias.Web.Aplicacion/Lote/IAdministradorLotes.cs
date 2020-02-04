using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
using Coqueta.Incidencias.Web.Datos.Contexto;


namespace Coqueta.Incidencias.Web.Aplicacion.Lotes
{
    public interface IAdministradorLotes
    {
        List<Lote> ObtenerListadoLotes();

        List<Lote> ObtenerDatosLotes(string Id);
    }
}
