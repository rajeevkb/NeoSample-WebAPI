using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using NeoSample.Models;

namespace NeoSample.DAL
{
    public class ZooSightingDemoDb : DbContext
    {
        public DbSet<Zoo> Zoos { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<ZooAnimalSighting> Sightings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

            builder.UseSqlServer(@"Server=Glenn-PC;Database=NeoSample-WebAPI-Test;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
            modelBuilder.Entity<Zoo>(e =>
                {
                    e.Property(z => z.Id)
                        .ForSqlServer()
                        .UseIdentity();
                    e.Collection(a => a.Animals);
                    
                });
                    
            modelBuilder.Entity<Animal>().Property(a => a.Id)
                .ForSqlServer()
                .UseIdentity();
            
            modelBuilder.Entity<ZooAnimalSighting>().Property(s => s.Id)
                .ForSqlServer()
                .UseIdentity();
            
        }
    }
}
