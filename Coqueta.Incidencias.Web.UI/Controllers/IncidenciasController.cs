using Coqueta.Core.Criptografia;
using Coqueta.Incidencias.Web.Aplicacion.Contexto;
using Coqueta.Incidencias.Web.Aplicacion.Incidencias;
using Coqueta.Incidencias.Web.Aplicacion.Lotes;
using Coqueta.Incidencias.Web.Comun.Constantes;
using Coqueta.Incidencias.Web.Datos.Contexto;
using Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;





namespace Coqueta.Incidencias.Web.UI.Controllers
{
    public class IncidenciasController : Controller
    {
        private IAdministradorLotes administradorLotes;
        private IAdministradorIncidencias administradorIncidencias;
        private ModeloDatos DataModel;

        public IncidenciasController()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[ConstanteComun.CadenaConexion].ConnectionString;
            this.administradorLotes = new AdministradorLotes(cadenaConexion);
            this.administradorIncidencias = new AdministradorIncidencias(cadenaConexion);
            this.DataModel = new ModeloDatos(cadenaConexion);

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
            //ContextoConfiguracion
            
            // Checking no of files injected in Request object  
            if (Request.Files.Count > 0)
            {
                try
                {
                    //  Get all files from Request object  
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        //string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";  
                        //string filename = Path.GetFileName(Request.Files[i].FileName);  

                        HttpPostedFileBase file = files[i];


                        string fname;

                        // Checking for Internet Explorer  
                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\' });
                            fname = testfiles[testfiles.Length - 1];
                        }
                        else
                        {
                            fname = file.FileName;
                        }

                        // Get the complete folder path and store the file inside it.  
                        fname = Path.Combine("C:\\Uploads\\", fname);

                        file.SaveAs(fname);
                    }
                    // Returns message that successfully uploaded  
                    return Json("File Uploaded Successfully!");
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selected.");
            }

            //incObj.Id = FuncionHash.GenerarHash();
            //incObj.FechaRegistroIncidencia = DateTime.Now;
            //incObj.UsuarioId = ContextoSesion.UsuarioID;
            //DataModel.Incidencias.Add(incObj);
            //DataModel.SaveChanges();

            //return Json(incObj);

        }


      

    }
}