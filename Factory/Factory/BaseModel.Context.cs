﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Factory
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_scriptEntities : DbContext
    {
        public db_scriptEntities()
            : base("name=db_scriptEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<color> colors { get; set; }
        public virtual DbSet<cutting> cuttings { get; set; }
        public virtual DbSet<drawing> drawings { get; set; }
        public virtual DbSet<fabric_color> fabric_color { get; set; }
        public virtual DbSet<fabric_drawing> fabric_drawing { get; set; }
        public virtual DbSet<fabric_structure> fabric_structure { get; set; }
        public virtual DbSet<fabric_warehouse> fabric_warehouse { get; set; }
        public virtual DbSet<fabric> fabrics { get; set; }
        public virtual DbSet<fabrics_product> fabrics_product { get; set; }
        public virtual DbSet<furniture_type> furniture_type { get; set; }
        public virtual DbSet<furniture_warehouse> furniture_warehouse { get; set; }
        public virtual DbSet<furniture> furnitures { get; set; }
        public virtual DbSet<furnitures_product> furnitures_product { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<structure> structures { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<type> types { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}