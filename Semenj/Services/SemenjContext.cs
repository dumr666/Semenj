using Microsoft.EntityFrameworkCore;
using Semenj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semenj.Services
{
    public class SemenjContext : DbContext
    {
        public SemenjContext(DbContextOptions<SemenjContext> options) 
            : base(options)
        { }
        
        // Expose data to API
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Homestead> Homesteads { get; set; }

        // Database table relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
             *   Table Users
             */

            // Assing new guid on add
            modelBuilder
                .Entity<User>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
            
            /*
             *  Product table
             */
            // Assing FK to product table
            modelBuilder
                .Entity<Product>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder
                .Entity<Product>()
                .HasOne(x => x.Seller)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.SellerId);


            
        }
    }
}
