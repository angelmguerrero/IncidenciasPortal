﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModeloDatos : DbContext
    {
        public ModeloDatos()
            : base("name=ModeloDatos")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TipoIncidencia> TipoIncidencias { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Incidencia> Incidencias { get; set; }
        public virtual DbSet<ParametroAplicacion> ParametroAplicacions { get; set; }
        public virtual DbSet<FotoPorlIncidencia> FotoPorlIncidencias { get; set; }
        public virtual DbSet<LotesMontado> LotesMontadoes { get; set; }
    }
}
