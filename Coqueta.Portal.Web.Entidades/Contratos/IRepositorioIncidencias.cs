﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coqueta.Incidencias.Web.Entidades.Dominio.Incidencias;

namespace Coqueta.Incidencias.Web.Entidades.Contratos
{
    public interface IRepositorioIncidencias
    {
        List<TipoIncidencias> ObtenerTipoIncidencias();

    }
}
