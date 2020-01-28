using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coqueta.Incidencias.Web.Datos.Contexto;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Entidades.Modelo;
using Coqueta.Incidencias.Web.Aplicacion.Autenticacion;
using System.Configuration;

namespace Coqueta.Incidencias.Web.UI.Controllers
{
    public class AccesoController : Controller
    {
        private IAdministradorAutenticacion administradorAutenticacion;


        public AccesoController()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[ConstanteComun.CadenaConexion].ConnectionString;
            this.administradorAutenticacion = new AdministradorAutenticacion(cadenaConexion);
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Persona per)
        {
            EnumeradoAutenticacion resultadoAutenticacion = this.administradorAutenticacion.AutenticarUsuario(per.NombreUsuario, per.Password);

            return View("Index");
        }
    }
}