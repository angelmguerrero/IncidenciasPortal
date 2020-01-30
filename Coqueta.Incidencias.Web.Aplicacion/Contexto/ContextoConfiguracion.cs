using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Datos.Contexto;
using System.Configuration;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Datos.Repositorio;
using Coqueta.Incidencias.Web.Entidades.Dominio.Configuracion;


namespace Coqueta.Incidencias.Web.Aplicacion.Contexto
{
    public class ContextoConfiguracion
    {
        private string cadenaConexion;

        public ContextoConfiguracion(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }



        #region Métodos Publicos
        public string ObtenerValorParametro(EnumeradorParametro enumeradoParametro)
        {
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
