using System.Collections.Generic;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataModel
{
    public class Context : DbContext
    {
        public DbSet<BreadType> Breads { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<BreadTypeIngredient> BreadTypeIngredients { get; set; }
        public DbSet<OrderBreadType> OrderBreadTypes { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .HasKey(c => new { c.OfficeID, c.BreadTypeID });

            modelBuilder.Entity<BreadTypeIngredient>()
                .HasKey(c => new { c.BreadTypeID, c.IngredientID });

            modelBuilder.Entity<OrderBreadType>()
                .HasKey(c => new { c.OrderID, c.BreadTypeID });
        }
        public override int SaveChanges()
        {
            var modificationHistoryList = this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory &&
                    (e.State == EntityState.Added ||
                    e.State == EntityState.Modified))
                .Select(e => e.Entity as IModificationHistory);
            foreach (var modificationHistory in modificationHistoryList)
            {
                modificationHistory.DateModified = DateTime.Now;
                if (modificationHistory.DateCreated == DateTime.MinValue)
                    modificationHistory.DateCreated = DateTime.Now;
            }
            return base.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BakeryFreshBread", b => b.MigrationsAssembly("BakeryFreshBreadAPI"));
            
        }
    }
}