﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDEFEntities : DbContext
    {
        public BDEFEntities()
            : base("name=BDEFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleRepuesto> DetalleRepuesto { get; set; }
        public virtual DbSet<MarcaVehiculo> MarcaVehiculo { get; set; }
        public virtual DbSet<ModeloVehiculo> ModeloVehiculo { get; set; }
        public virtual DbSet<OrdenServicio> OrdenServicio { get; set; }
        public virtual DbSet<Repuesto> Repuesto { get; set; }
        public virtual DbSet<Tecnico> Tecnico { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
    }
}
