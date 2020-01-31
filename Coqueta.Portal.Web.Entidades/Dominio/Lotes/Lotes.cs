using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Lotes
{
    public class Lotes
    {
        public Lotes()
        { }


        public string Lote { get; set; }
        public int Estilo { get; set; }
        public string Cominacion { get; set; }
        public string Suela { get; set; }
        [DisplayName("Numero de Semana")]
        public Nullable<int> NumSem { get; set; }


    }
}
