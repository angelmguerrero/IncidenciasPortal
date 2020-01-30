using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Entidades.Dominio.Configuracion;
using Coqueta.Incidencias.Web.Datos.Contexto;
using Coqueta.Incidencias.Web.Comun.Enumerados;


namespace Coqueta.Incidencias.Web.Datos.Repositorio
{
    public class RepositorioParametros :IRepositorioParametros
    {
        #region Campos
        private string cadenaConexion;
        #endregion

        #region Constructor
        public RepositorioParametros(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        #endregion


        #region Métodos Públicos
        Parametros IRepositorioParametros.ObtenerValorParametro(EnumeradorParametro enumeradoParametro)
        {
            using (ModeloDatos db = new ModeloDatos(cadenaConexion))
            {
                var param = db.ParametroAplicacions.Where(a => a.Id.Equals(enumeradoParametro)).FirstOrDefault();
                if (param != null)
                {
                    Parametros parametro = new Parametros();
                    parametro.Id = param.Id;
                    parametro.Valor = parametro.Valor;
                    return parametro;
                }
                else
                    return null;

            }
        }

        #endregion







    }
}
