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
    
    public partial class TipoIncidencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoIncidencia()
        {
            this.lIncidencias = new HashSet<Incidencia>();
        }
    
        public int Id { get; set; }
        public string Incidencia { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencia> lIncidencias { get; set; }
    }
}
