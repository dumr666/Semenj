using Microsoft.EntityFrameworkCore;
using SemenjAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.Services
{
    public class SemenjAPIContext : DbContext
    {
        public SemenjAPIContext(DbContextOptions<SemenjAPIContext> options)
            : base(options)
        { }

        // Expose data to API
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

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
