using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias;
using Coqueta.Incidencias.Web.Datos.Repositorio;
using Coqueta.Incidencias.Web.Entidades.Contratos;

namespace Coqueta.Incidencias.Web.Aplicacion.Incidencias
{
    public class AdministradorIncidencias: IAdministradorIncidencias
    {
        private string cadenaConexion;

        public AdministradorIncidencias(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }


        List<TipoIncidencias> IAdministradorIncidencias.ObtenerTipoIncidencias()
        {

            IRepositorioIncidencias repositorioIncidencias = new RepositorioIncidencias(cadenaConexion);
            List<TipoIncidencias> tipoIncidencia = repositorioIncidencias.ObtenerTipoIncidencias();
            return tipoIncidencia;
            
        }
    }
}
