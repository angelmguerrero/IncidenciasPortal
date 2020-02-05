using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias
{
    public class Incidencias
    {
        public string Id { get; set; }
        public string Lote { get; set; }
        public Nullable<short> Riel { get; set; }
        public string Semana { get; set; }
        public Nullable<int> TipoIncidencia { get; set; }
        public Nullable<int> TotalIncidencias { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        
    }
}
