using Coqueta.Incidencias.Web.Comun.Enumerados;


namespace Coqueta.Incidencias.Web.Aplicacion.Autenticacion
{
    public interface IAdministradorAutenticacion
    {
        #region Métodos


        EnumeradoAutenticacion AutenticarUsuario(string nombreUsuario, string password);
        #endregion
    }
}
