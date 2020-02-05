using Coqueta.Incidencias.Web.Aplicacion.Lotes;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
using Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Coqueta.Incidencias.Web.Aplicacion.Incidencias;
using Coqueta.Incidencias.Web.Datos.Contexto;
using Coqueta.Core.Criptografia;

namespace Coqueta.Incidencias.Web.UI.Controllers
{
    public class IncidenciasController : Controller
    {
        private IAdministradorLotes administradorLotes;
        private IAdministradorIncidencias administradorIncidencias;

        public IncidenciasController()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[ConstanteComun.CadenaConexion].ConnectionString;
            this.administradorLotes = new AdministradorLotes(cadenaConexion);
            this.administradorIncidencias = new AdministradorIncidencias(cadenaConexion);
            
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ObtenerLotes()
        {
            List<Lote> resultadoLotes = this.administradorLotes.ObtenerListadoLotes();
            return Json(resultadoLotes);
        }

        [HttpPost]
        public ActionResult ObtenerLotesDatos(string Id)
        {
            List<Lote> LotesData = this.administradorLotes.ObtenerDatosLotes(Id);
            return Json(LotesData);
        }


        [HttpPost]
        public ActionResult ObtenerTipoIncidencias()
        {
            List<TipoIncidencias> tipoIncidencias = this.administradorIncidencias.ObtenerTipoIncidencias();
            return Json(tipoIncidencias);
        }

        [HttpPost]
        public ActionResult AgregarIncidencia(ReporteIncidencia incide)
        {
            //ModeloDatos objIncidencia = new ModeloDatos(cadenaConexion);
            //FuncionHash.GenerarHash
            
            return null;
        }

    }
}