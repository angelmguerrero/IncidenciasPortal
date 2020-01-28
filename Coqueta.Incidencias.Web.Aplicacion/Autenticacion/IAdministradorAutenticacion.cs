﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Comun.Enumerados;


namespace Coqueta.Incidencias.Web.Aplicacion.Autenticacion
{
    public interface IAdministradorAutenticacion
    {
        #region Métodos


        EnumeradoAutenticacion AutenticarUsuario(string nombreUsuario, string password);
        #endregion
    }
}
