﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TORRES_backend.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbttcEntities1 : DbContext
    {
        public dbttcEntities1()
            : base("name=dbttcEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adminuser> adminusers { get; set; }
        public virtual DbSet<class_code_tb> class_code_tb { get; set; }
        public virtual DbSet<employeeUser> employeeUsers { get; set; }
        public virtual DbSet<report_a_bug> report_a_bug { get; set; }
        public virtual DbSet<training> trainings { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}