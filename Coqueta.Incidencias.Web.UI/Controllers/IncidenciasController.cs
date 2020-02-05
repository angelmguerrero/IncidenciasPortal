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

        //[HttpPost]
        //public ActionResult AgregarIncidencia(FormCollection fc, HttpPostedFileBase file)
        //{
        //    //tbl_details tbl = new tbl_details();
        //    var allowedExtensions = new[] {
        //    ".JPG", ".png", ".jpg", "jpeg"
        //};
        //    //tbl.Id = fc["Id"].ToString();
        //    //tbl.Image_url = file.ToString(); //getting complete url  
        //    //tbl.Name = fc["Name"].ToString();
        //    var fileName = Path.GetFileName(file.FileName); //getting only file name(ex-ganesh.jpg)  
        //    var ext = Path.GetExtension(file.FileName); //getting the extension(ex-.jpg)  
        //    if (allowedExtensions.Contains(ext)) //check what type of extension  
        //    {
        //        string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
        //        string myfile = name + "_" + ext; //appending the name with id  
        //                                                   // store the file inside ~/project folder(Img)  
        //        var path = Path.Combine(Server.MapPath("~/Img"), myfile);
        //        //tbl.Image_url = path;
        //        //obj.tbl_details.Add(tbl);
        //        //obj.SaveChanges();
        //        file.SaveAs(path);
        //    }
        //    else
        //    {
        //        ViewBag.message = "Please choose only Image file";
        //    }
        //    return View();
        //}







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

        //[HttpPost]
        //public ActionResult AgregarIncidencia(Incidencia incObj )
        //{
        //    incObj.Id = FuncionHash.GenerarHash();
        //    incObj.FechaRegistroIncidencia = DateTime.Now;
        //    incObj.UsuarioId = ContextoSesion.UsuarioID;
        //    DataModel.Incidencias.Add(incObj);
        //    DataModel.SaveChanges();

        //    return Json(incObj);

        //}

    }
}