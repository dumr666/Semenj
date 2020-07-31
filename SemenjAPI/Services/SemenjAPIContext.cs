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
        public DbSet<Homestead> Homesteads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductSort> ProductsSorts { get; set; }

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

            modelBuilder
                .Entity<User>()
                .HasOne(x => x.Homestead)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.HomesteadId);

            modelBuilder
                .Entity<User>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Seller);

            /*
             *  Product table
             */

            modelBuilder
                .Entity<Product>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder
                .Entity<Product>()
                .HasOne(x => x.ProductSort)
                .WithMany(x => x.Products);


            /*
             * Homestead
             */

            modelBuilder
                .Entity<Homestead>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder
                .Entity<Homestead>()
                .HasMany(x => x.Users)
                .WithOne(x => x.Homestead);

            modelBuilder
                .Entity<Homestead>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Homestead)
                .HasForeignKey(x => x.HomesteadId);

            /*
             *  Product sort 
             */
            modelBuilder
                .Entity<ProductSort>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

        }
    }
}
