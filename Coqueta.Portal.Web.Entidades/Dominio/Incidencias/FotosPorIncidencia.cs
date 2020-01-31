using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias
{
    public class FotosPorIncidencia
    {
        public int Id { get; set; }
        public int IncidenciasId { get; set; }
        public string Foto { get; set; }
    }
}
