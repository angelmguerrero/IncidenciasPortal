using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
using Coqueta.Incidencias.Web.Datos.Repositorio;
using Coqueta.Incidencias.Web.Entidades.Contratos;

namespace Coqueta.Incidencias.Web.Aplicacion.Lotes
{
    public class AdministradorLotes: IAdministradorLotes
    {
        private string cadenaConexion;

        public AdministradorLotes(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        List<Lote> IAdministradorLotes.ObtenerListadoLotes()
        {

            IRepositorioLotes repositorioLotes = new RepositorioLotes(cadenaConexion);
            List<Lote> LoteActivo = repositorioLotes.ObtenerLotes();

            return LoteActivo;

        }
    }
}
