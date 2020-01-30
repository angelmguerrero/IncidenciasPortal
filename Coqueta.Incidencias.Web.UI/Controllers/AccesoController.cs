using Coqueta.Incidencias.Web.Aplicacion.Autenticacion;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Comun.Enumerados;
using Coqueta.Incidencias.Web.Entidades.Modelo;
using System.Configuration;
using System.Web.Mvc;
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
      
        public ActionResult Login()
        {

            return this.View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario per)
        {
            if (this.ModelState.IsValid)
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
            }
           
            return this.View("Login", per);
        }


        [HttpGet]
        public ActionResult CerrarSesion()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Acceso");



          
        }




    }
}