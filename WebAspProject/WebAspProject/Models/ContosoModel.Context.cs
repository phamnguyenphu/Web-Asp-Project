﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAspProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CUAHANGOTOEntities : DbContext
    {
        public CUAHANGOTOEntities()
            : base("name=CUAHANGOTOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer_info> Customer_info { get; set; }
        public virtual DbSet<customerConsulting_info> customerConsulting_info { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Staff_info> Staff_info { get; set; }
    }
}