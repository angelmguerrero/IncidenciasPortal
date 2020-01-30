using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Entidades.Dominio.Configuracion;

namespace Coqueta.Incidencias.Web.Entidades.Contratos
{
    public interface IRepositorioParametros
    {
        Parametros ObtenerValorParametro(EnumeradorParametro enumeradoParametro);
    }
}
