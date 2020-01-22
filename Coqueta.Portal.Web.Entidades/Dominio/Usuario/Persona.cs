using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Portal.Web.Entidades.Dominio.Usuario
{
    
    public class Persona
    {
        #region Constructor
        public Persona()
        { }
        #endregion

        #region Propiedades
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }

        #endregion


    }
}
