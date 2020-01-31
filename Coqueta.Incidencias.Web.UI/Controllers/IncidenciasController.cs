using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Coqueta.Incidencias.Web.Entidades.Dominio.

namespace Coqueta.Incidencias.Web.UI.Controllers
{
    public class IncidenciasController : Controller
    {
        // GET: Incidencias
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgregarIncidencia()
        {
            return null;
        }
    }
}