using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Contratos;
using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
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
        List<Lote> IRepositorioLotes.ObtenerLotes()
        {
            ModeloDatos objEntity = new ModeloDatos(cadenaConexion);

            var query = from lot in objEntity.LotesMontadoes
                        select new Lote()
                        {
                            Lotes = lot.Lote,
                            Estilo = lot.Estilo,
                            Combinacion = lot.Combinacion,
                            Suela = lot.Suela,
                            NumSem = lot.NumSemana
                        };

            return query.ToList();
        }



        List<Lote> IRepositorioLotes.ObtenerDatosLote(string Id)
        {
            ModeloDatos objLotes = new ModeloDatos(cadenaConexion);

            var query = from lot in objLotes.LotesMontadoes
                        where lot.Lote == Id
                        select new Lote()
                        {
                            Lotes = lot.Lote,
                            Estilo = lot.Estilo,
                            Combinacion = lot.Combinacion,
                            Suela = lot.Suela,
                            NumSem = lot.NumSemana
                        };
            return query.ToList();
        }
        #endregion
    }
}
