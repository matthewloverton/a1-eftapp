﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFTDBEntities : DbContext
    {
        public EFTDBEntities()
            : base("name=EFTDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ammunition> Ammunitions { get; set; }
        public virtual DbSet<Caliber> Calibers { get; set; }
        public virtual DbSet<Gear> Gears { get; set; }
        public virtual DbSet<Loadout> Loadouts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }
    }
}
