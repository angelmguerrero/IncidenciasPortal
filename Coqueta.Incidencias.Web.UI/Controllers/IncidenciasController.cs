using Coqueta.Incidencias.Web.Aplicacion.Lotes;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
using Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Coqueta.Incidencias.Web.Aplicacion.Incidencias;
using Coqueta.Incidencias.Web.Aplicacion.Contexto;

using Coqueta.Incidencias.Web.Datos.Contexto;
using Coqueta.Core.Criptografia;
using System;

namespace Coqueta.Incidencias.Web.UI.Controllers
{
    public class IncidenciasController : Controller
    {
        private IAdministradorLotes administradorLotes;
        private IAdministradorIncidencias administradorIncidencias;
        private ModeloDatos test;

        public IncidenciasController()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[ConstanteComun.CadenaConexion].ConnectionString;
            this.administradorLotes = new AdministradorLotes(cadenaConexion);
            this.administradorIncidencias = new AdministradorIncidencias(cadenaConexion);
            this.test = new ModeloDatos(cadenaConexion);
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
        public ActionResult AgregarIncidencia(Incidencia incObj)
        {
            //Incidencia incide = new Incidencia();

            //incide.Id = FuncionHash.GenerarHash();
            //incide.Lote = incObj.Lote;
            //incide.Riel = incObj.Riel;
            //incide.Semana = incObj.Semana;
            //incide.FechaRegistroIncidencia = DateTime.Now;
            //incide.TipoIncidenciaId = incObj.TipoIncidencia;
            //incide.Descripcion = incObj.Descripcion;
            //incide.UsuarioId = ContextoSesion.UsuarioID;


            incObj.Id = FuncionHash.GenerarHash();
            incObj.FechaRegistroIncidencia = DateTime.Now;
            incObj.UsuarioId = ContextoSesion.UsuarioID;

            test.Incidencias.Add(incObj);
            test.SaveChanges();

            return Json(incObj);
        }

    }
}