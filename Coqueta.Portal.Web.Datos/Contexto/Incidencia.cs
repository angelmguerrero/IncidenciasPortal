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
            this.rFotoPorlIncidencias = new HashSet<FotoPorlIncidencia>();
        }
    
        public int Id { get; set; }
        public string Lote { get; set; }
        public Nullable<short> Riel { get; set; }
        public string Semana { get; set; }
        public Nullable<System.DateTime> FechaRegistroIncidencia { get; set; }
        public Nullable<short> TipoIncidenciaId { get; set; }
        public Nullable<int> TotalIncidencias { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> UsuarioId { get; set; }
    
        public virtual TipoIncidencia cTipoIncidencia { get; set; }
        public virtual Usuarios cUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FotoPorlIncidencia> rFotoPorlIncidencias { get; set; }
    }
}
