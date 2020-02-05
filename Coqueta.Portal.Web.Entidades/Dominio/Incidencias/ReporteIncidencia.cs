using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias
{
    public class ReporteIncidencia
    {
        public string Id { get; set; }
        public string Lote { get; set; }
        public Nullable<short> Riel { get; set; }
        public string Semana { get; set; }
        public int TipoIncidencia { get; set; }
        public int TotalIncidencia { get; set; }
        public string Descripcion { get; set; }
        public int Usuario { get; set; }
        public List<FotosPorIncidencia> Foto { get; set; }
    }
}
