using Coqueta.Incidencias.Web.Datos.Repositorio;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
using System.Collections.Generic;

namespace Coqueta.Incidencias.Web.Aplicacion.Lotes
{
    public class AdministradorLotes: IAdministradorLotes
    {
        private string cadenaConexion;

        public AdministradorLotes(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        List<Lote> IAdministradorLotes.ObtenerListadoLotes(int banda)
        {

            IRepositorioLotes repositorioLotes = new RepositorioLotes(cadenaConexion);
            List<Lote> LoteActivo = repositorioLotes.ObtenerLotes(banda);

            return LoteActivo;

        }

        List<Lote> IAdministradorLotes.ObtenerDatosLotes(string Id)
        {
            IRepositorioLotes repositorioLotes = new RepositorioLotes(cadenaConexion);
            List<Lote> LoteDatos = repositorioLotes.ObtenerDatosLote(Id);
            return LoteDatos;
        }
    }
}
