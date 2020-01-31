using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lotes;
using Coqueta.Incidencias.Web.Datos.Contexto;

namespace Coqueta.Incidencias.Web.Datos.Repositorio
{
    public class RepositorioLotes : IRepositorioLotes
    {
        private string cadenaConexion;

        #region Constructor
        public RepositorioLotes(string cadenaCionexion)
        {
            this.cadenaConexion = cadenaCionexion;
        }
        #endregion

        #region Métodos Públicos
        List<Lotes> IRepositorioLotes.ObtenerLotes()
        {
            ModeloDatos objEntity = new ModeloDatos(cadenaConexion);

            var query = from lot in objEntity.LotesMontadoes
                        select new Lotes()
                        {
                            Lote = lot.Lote,
                            Estilo = lot.Estilo,
                            Cominacion = lot.Combinacion,
                            Suela = lot.Suela,
                            NumSem = lot.NumSemana
                        };

            return new List<Lotes>();
        }

        #endregion
    }
}
