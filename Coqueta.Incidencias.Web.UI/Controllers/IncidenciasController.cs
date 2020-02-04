using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coqueta.Incidencias.Web.Aplicacion.Lotes;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;

namespace Coqueta.Incidencias.Web.UI.Controllers
{
    public class IncidenciasController : Controller
    {
        private IAdministradorLotes administradorLotes;
        public IncidenciasController()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[ConstanteComun.CadenaConexion].ConnectionString;
            this.administradorLotes = new AdministradorLotes(cadenaConexion);
        }
        // GET: Incidencias
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult ObtenerLotes()
        {
            List<Lote> resultadoLotes = this.administradorLotes.ObtenerListadoLotes();
            return Json(resultadoLotes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AgregarIncidencia()
        {
            return null;
        }
    }
}