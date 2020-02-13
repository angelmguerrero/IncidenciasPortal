﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Coqueta.Incidencias.Web.Entidades.Dominio.Lote
{
    public class Lote
    {
        public Lote()
        { }


        public string Lotes { get; set; }
        public int Estilo { get; set; }
        public string Combinacion { get; set; }
        public string Suela { get; set; }
        [DisplayName("Numero de Semana")]
        public Nullable<int> NumSem { get; set; }
        public int Banda { get; set; }
        public int Pares { get; set; }


    }
}
