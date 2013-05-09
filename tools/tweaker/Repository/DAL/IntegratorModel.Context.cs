﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class IntegratorEntities1 : DbContext
    {
        public IntegratorEntities1()
            : base("name=IntegratorEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CMYKLookup> CMYKLookups { get; set; }
        public DbSet<EmailList> EmailLists { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<ImageUpdate> ImageUpdates { get; set; }
        public DbSet<InsertedDataHistory> InsertedDataHistories { get; set; }
        public DbSet<StatusMessage> StatusMessages { get; set; }
    
        public virtual int InsertImageUpdate(string imagePath, Nullable<int> micrositeId)
        {
            var imagePathParameter = imagePath != null ?
                new ObjectParameter("imagePath", imagePath) :
                new ObjectParameter("imagePath", typeof(string));
    
            var micrositeIdParameter = micrositeId.HasValue ?
                new ObjectParameter("micrositeId", micrositeId) :
                new ObjectParameter("micrositeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertImageUpdate", imagePathParameter, micrositeIdParameter);
        }
    }
}