using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Incidencias.Web.Datos.Contexto
{
    public partial class ModeloDatos: DbContext
    {
        public ModeloDatos(string connectionString)
            :base(connectionString)
        {

        }
    }

}
