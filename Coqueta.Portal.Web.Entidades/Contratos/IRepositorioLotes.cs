﻿using Coqueta.Incidencias.Web.Entidades.Dominio.Lote;
using System.Collections.Generic;

namespace Coqueta.Incidencias.Web.Entidades.Contratos
{
    public interface IRepositorioLotes
    {
        List<Lote> ObtenerLotes(int banda);

        List<Lote> ObtenerDatosLote(string Id);
    }
}
