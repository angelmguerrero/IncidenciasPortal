using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Entidades.Modelo;
using Coqueta.Incidencias.Web.Aplicacion.Autenticacion;
using System.Configuration;
using System.Web.Security;

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



        [HttpGet]
      
        public ActionResult Index()
        {

            return this.View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Persona per)
        {
            EnumeradoAutenticacion resultadoAutenticacion = this.administradorAutenticacion.AutenticarUsuario(per.NombreUsuario, per.Password);

            switch (resultadoAutenticacion)
            {
                case EnumeradoAutenticacion.AccesoValido:
                    return this.RedirectToAction("Index", "Home");
                default:
                    this.ModelState.AddModelError(string.Empty, "Usuario no existe o contraseña es inválida.");
                    break;
            }
            return this.View("Index", per);
        }


        [HttpGet]
        public ActionResult CerrarSesion()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Acceso");



          
        }




    }
}