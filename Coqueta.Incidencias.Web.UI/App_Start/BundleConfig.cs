using System.Web;
using System.Web.Optimization;

namespace Coqueta.Incidencias.Web.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            #region Layout Público

            bundles.Add(new StyleBundle("~/Content/css/LayoutPublico").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Componentes/sweetalert/dist/sweetalert.css",
                "~/Content/css/LayoutPublico.css"));

            bundles.Add(new StyleBundle("~/Scripts/LayoutPublico").Include(
                "~/Scripts/jquery-3.1.1.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Componentes/sweetalert/dist/sweetalert.min.js",
                "~/Scripts/Coqueta.Core.js",
                "~/Scripts/Layout/LayoutPublico.js"));
            #endregion



            #region Layout Privado

            bundles.Add(new StyleBundle("~/Content/css/LayoutPrivado").Include(
                "~/Componentes/fontawesome/css/font-awesome.min.css",
                "~/Componentes/simple-line-icons/css/simple-line-icons.css",
                "~/Componentes/animate.css/animate.min.css",
                "~/Componentes/whirl/dist/whirl.css",
                "~/Content/css/LayoutPrivado.css",
                "~/Componentes/datatables/media/css/dataTables.bootstrap.css",
                "~/Componentes/easyAutocomplete/easy-autocomplete.min.css",
                "~/Componentes/easyAutocomplete/easy-autocomplete.themes.min.css",
                "~/Componentes/sweetalert/dist/sweetalert.css",
                "~/Componentes/whirl/dist/whirl.css",
                "~/Componentes/animate.css/animate.min.css",
                "~/Componentes/blueimp-file-upload/css/jquery.fileupload.css",
                "~/Componentes/datePicker/daterangepicker.css",
                "~/Componentes/pageguide/pageguide.min.css",
                "~/Componentes/jAlert/jAlert.css"));

            bundles.Add(new StyleBundle("~/Scripts/LayoutPrivado").Include(
                "~/Componentes/modernizr/modernizr.custom.js",
                "~/Componentes/matchMedia/matchMedia.js",
                "~/Scripts/jquery-3.1.1.min.js",
                "~/Componentes/jQuery-Storage-API/jquery.storageapi.js",
                "~/Scripts/bootstrap.min.js",
                "~/Componentes/jquery.easing/js/jquery.easing.js",
                "~/Componentes/animo.js/animo.js",
                "~/Componentes/slimScroll/jquery.slimscroll.min.js",
                "~/Componentes/moment/min/moment-with-locales.min.js",
                "~/Scripts/app.js",
                "~/Componentes/datatables/jquery.dataTables.min.js",
                "~/Componentes/datatables/dataTables.bootstrap.min.js",
                "~/Componentes/datatables/dataTables.buttons.min.js",
                "~/Componentes/datatables/buttons.bootstrap.min.js",
                "~/Componentes/datatables/buttons.html5.min.js",
                "~/Componentes/sweetalert/dist/sweetalert.min.js",
                "~/Componentes/jquery.inputmask/dist/jquery.inputmask.bundle.js",
                "~/Componentes/pageguide/pageguide.min.js",
                "~/Componentes/jAlert/jAlert.min.js",
                "~/Componentes/jAlert/jAlert-functions.min.js",
                "~/Componentes/jTimeout/jTimeout.min.js",
                "~/Scripts/Coqueta.Core.js",
                "~/Scripts/Layout/LayoutPrivado.js"));
            #endregion


        }
    }
}
