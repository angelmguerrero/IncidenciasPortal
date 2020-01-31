using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias
{
    public class Incidencias
    {
        public int Id { get; set; }
        public string Lote { get; set; }
        public int Riel { get; set; }
        public string Semana { get; set; }
        public int TipoIncidencia { get; set; }
        public int TotalIncidencia { get; set; }
        public string Descripcion { get; set; }
        
    }
}
