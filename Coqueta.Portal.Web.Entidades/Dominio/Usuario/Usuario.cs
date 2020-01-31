using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Usuario
{
    
    public class Usuario
    {
        #region Constructor
        public Usuario()
        { }
        #endregion

        #region Propiedades
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre de usuario es requerido")]
        public string NombreUsuario { get; set; }

        public string Nombre { get; set; }


        [Required(ErrorMessage = "Contraseña es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        #endregion


    }
}
