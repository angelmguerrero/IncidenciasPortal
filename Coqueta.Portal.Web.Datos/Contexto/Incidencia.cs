//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coqueta.Incidencias.Web.Datos.Contexto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incidencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incidencia()
        {
            this.rFotoPorlIncidencias = new HashSet<rFotoPorlIncidencia>();
        }
    
        public int Id { get; set; }
        public Nullable<int> TipoProductoId { get; set; }
        public Nullable<short> Lote { get; set; }
        public string NombreIncidencia { get; set; }
        public Nullable<int> TotalIncidencias { get; set; }
        public string Descripcion { get; set; }
    
        public virtual TipoIncidencia cTipoIncidencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rFotoPorlIncidencia> rFotoPorlIncidencias { get; set; }
    }
}
