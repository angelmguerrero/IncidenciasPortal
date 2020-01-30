using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Coqueta.Incidencias.Web.Entidades.Modelo
{
    public partial class Usuario
    {
        [Required(ErrorMessage = "Nombre de usuario es requerido")]   
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Contraseña es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
    }
}
