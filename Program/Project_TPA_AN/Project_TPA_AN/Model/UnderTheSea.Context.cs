﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_TPA_AN.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UnderTheSeaEntities : DbContext
    {
        public UnderTheSeaEntities()
            : base("name=UnderTheSeaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Attraction> Attractions { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FundRequest> FundRequests { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<PurchasementReport> PurchasementReports { get; set; }
        public virtual DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public virtual DbSet<RequestAttraction> RequestAttractions { get; set; }
        public virtual DbSet<RequestRide> RequestRides { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketTransaction> TicketTransactions { get; set; }
    }
}
