﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Usuario
{
    
    public partial class Usuarios
    {
        #region Constructor
        public Usuarios()
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