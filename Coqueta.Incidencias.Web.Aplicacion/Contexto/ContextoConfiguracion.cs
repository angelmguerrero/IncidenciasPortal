using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Datos.Repositorio;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Entidades.Dominio.Configuracion;

using Coqueta.Incidencias.Web.Comun.Constantes;

using System.Configuration;


namespace Coqueta.Incidencias.Web.Aplicacion.Contexto
{
    public class ContextoConfiguracion
    {
    

        #region Métodos Publicos
        public static string ObtenerValorParametro(EnumeradorParametro enumeradoParametro)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[ConstanteComun.CadenaConexion].ConnectionString;

            IRepositorioParametros repositorioParametros = new RepositorioParametros(cadenaConexion);
            Parametros parametro = repositorioParametros.ObtenerValorParametro(enumeradoParametro);

            if (parametro != null)
            {
                return parametro.Valor;
            }
            else
                return null;
        }
        #endregion


    }
}
