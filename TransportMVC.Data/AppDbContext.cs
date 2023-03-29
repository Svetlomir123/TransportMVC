using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Transactions;
using TransportMVC.Models;

namespace TransportMVC.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-4FI5MGD; Initial Catalog=TransportEF; Integrated Security=true; Trusted_Connection=true";

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
