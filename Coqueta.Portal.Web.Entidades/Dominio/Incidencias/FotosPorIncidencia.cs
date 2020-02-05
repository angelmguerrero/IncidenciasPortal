using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias
{
    public class FotosPorIncidencia
    {
        public string Id { get; set; }
        public string IncidenciasId { get; set; }
        public string ImageUrl { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name ="Subir Archivo")]
        [Required(ErrorMessage ="Por favor cargue un archivo.")]
        public string FotoName { get; set; }
    }
}
