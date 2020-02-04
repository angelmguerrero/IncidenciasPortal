using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Datos.Contexto;
using Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias;
using Coqueta.Incidencias.Web.Entidades.Contratos;

namespace Coqueta.Incidencias.Web.Datos.Repositorio
{
   public class RepositorioIncidencias: IRepositorioIncidencias
    {
        private string cadenaConexion;

        #region Constructor
        public RepositorioIncidencias(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        #endregion

        #region Métodos Publicos
        List<TipoIncidencias> IRepositorioIncidencias.ObtenerTipoIncidencias()
        {
            ModeloDatos objEntity = new ModeloDatos(cadenaConexion);

            var query = from inc in objEntity.TipoIncidencias
                        where inc.Activo == true
                        select new TipoIncidencias
                        {
                            Id = inc.Id,
                            Incidencia = inc.Incidencia

                        };
            return query.ToList(); 
        }
        #endregion
    }
}
