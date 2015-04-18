using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using NeoSample.Models;
using System;

namespace NeoSample.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryStore(true);
           optionsBuilder.UseSqlServer("Server=Glenn-PC;Database=NeoSample-WebAPI-Demo;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
