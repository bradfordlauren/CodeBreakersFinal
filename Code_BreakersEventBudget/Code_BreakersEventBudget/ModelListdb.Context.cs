﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Code_BreakersEventBudget
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinalProj_ListEntities : DbContext
    {
        public FinalProj_ListEntities()
            : base("name=FinalProj_ListEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<ListItem> ListItems { get; set; }
        public virtual DbSet<Personal_Info> Personal_Infoes { get; set; }
    }
}