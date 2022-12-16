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

            Guid flour = Guid.NewGuid();
            Guid water = Guid.NewGuid();
            Guid salt = Guid.NewGuid();
            Guid yeast = Guid.NewGuid();
            Guid sugar = Guid.NewGuid();
            Guid milk = Guid.NewGuid();
            Guid butter = Guid.NewGuid();
            Guid egg = Guid.NewGuid();
            Guid honey = Guid.NewGuid();
            Guid lemonZest = Guid.NewGuid();
            Guid vanillaEssence = Guid.NewGuid();
            Guid sweetPotato = Guid.NewGuid();
            Guid sesameSeed = Guid.NewGuid();
            Guid gilding = Guid.NewGuid();

            modelBuilder.Entity<Ingredient>()
               .HasData(
                new Ingredient
                {
                    Id = flour,
                    Name = "Flour",
                },
                new Ingredient
                {
                    Id = water,
                    Name = "Water"
                },
                new Ingredient
                {
                    Id = salt,
                    Name = "Salt"
                },
                new Ingredient
                {
                    Id = yeast,
                    Name = "Yeast"
                },
                new Ingredient
                {
                    Id = sugar,
                    Name = "Sugar"
                },
                new Ingredient
                {
                    Id = milk,
                    Name = "Milk"
                },
                new Ingredient
                {
                    Id = butter,
                    Name = "Butter"
                },
                new Ingredient
                {
                    Id = egg,
                    Name = "Egg"
                },
                new Ingredient
                {
                    Id = honey,
                    Name = "Honey"
                },
                new Ingredient
                {
                    Id = lemonZest,
                    Name = "Lemon zest"
                },
                new Ingredient
                {
                    Id = vanillaEssence,
                    Name = "Vanilla essence"
                },
                new Ingredient
                {
                    Id = sweetPotato,
                    Name = "Sweet potato"
                },
                new Ingredient
                {
                    Id = sesameSeed,
                    Name = "Sesame seed"
                },
                new Ingredient
                {
                    Id = gilding,
                    Name = "Gilding"
                }
               );

            Guid baguette = Guid.NewGuid();
            Guid whiteBread = Guid.NewGuid();
            Guid milkBread = Guid.NewGuid();
            Guid hamgurgerBun = Guid.NewGuid();

            modelBuilder.Entity<BreadType>()
               .HasData(
                new BreadType 
                {
                    Id= baguette,
                    BreadName = "BAGUETTE",
                    Price = "2.0",
                    CookingTime = "15 min",
                    RestingTime = "0.5 hr",
                    FermentTime = "1 day",
                    CookingTemperature = 270,
                    Process = "MIX, REST, FOLD, REST, FOLD, FERMENT, CUT, SHAPE, REST COOK"
                },
                new BreadType
                {
                    Id= whiteBread,
                    BreadName = "WHITE BREAD",
                    Price = "2.5",
                    CookingTime = "30 min",
                    RestingTime = "1 hr",
                    FermentTime = "4 day",
                    CookingTemperature = 180,
                    Process = "MIX, CUT, FERMENT, SHAPE, REST, COOK"
                },
                new BreadType
                {

                    Id = milkBread,
                    BreadName = "MILK BREAD",
                    Price = "1.5",
                    CookingTime = "15 min",
                    RestingTime = "10 min",
                    FermentTime = "4 hrs",
                    CookingTemperature = 180,
                    Process = "MIX, CUT, REST, SHAPE, FERMENT, COOK"
                },
                new BreadType
                {

                    Id = hamgurgerBun,
                    BreadName = "HAMBURGUER BUN",
                    Price = "1.0",
                    CookingTime = "15 min",
                    RestingTime = "0.5 hr",
                    FermentTime = "4 hrs",
                    CookingTemperature = 180,
                    Process = "MIX, CUT, REST, SHAPE, FERMENT, PLACE, COOK"
                }
                );

            modelBuilder.Entity<BreadTypeIngredient>()
             .HasData(
                new BreadTypeIngredient { 
                    BreadTypeID = baguette,
                    IngredientID = flour,
                    Quantity = 280
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = baguette,
                    IngredientID = water,
                    Quantity = 210
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = baguette,
                    IngredientID = salt,
                    Quantity = 10
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = baguette,
                    IngredientID = yeast,
                    Quantity = 5
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = whiteBread,
                    IngredientID = flour,
                    Quantity = 1000
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = whiteBread,
                    IngredientID = water,
                    Quantity = 280
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = whiteBread,
                    IngredientID = salt,
                    Quantity = 20
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = whiteBread,
                    IngredientID = yeast,
                    Quantity = 20
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = whiteBread,
                    IngredientID = sugar,
                    Quantity = 80
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = whiteBread,
                    IngredientID = milk,
                    Quantity = 60
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = whiteBread,
                    IngredientID = butter,
                    Quantity = 100
                },

                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = flour,
                    Quantity = 55
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = water,
                    Quantity = 25
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = salt,
                    Quantity = 1
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = yeast,
                    Quantity = 3
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = sugar,
                    Quantity = 6
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = egg,
                    Quantity = 10
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = milk,
                    Quantity = 20
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = butter,
                    Quantity = 10
                },
                new BreadTypeIngredient
                {
                    BreadTypeID = milkBread,
                    IngredientID = honey,
                    Quantity = 2
                },
                 new BreadTypeIngredient
                 {
                     BreadTypeID = milkBread,
                     IngredientID = lemonZest,
                     Quantity = 1
                 },
                  new BreadTypeIngredient
                  {
                      BreadTypeID = milkBread,
                      IngredientID = vanillaEssence,
                      Quantity = 1
                  },

                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = flour,
                       Quantity = 100
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = water,
                       Quantity = 25
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = salt,
                       Quantity = 2
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = yeast,
                       Quantity = 4
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = sugar,
                       Quantity = 6
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = egg,
                       Quantity = 10
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = milk,
                       Quantity = 5
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = butter,
                       Quantity = 6
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = sweetPotato,
                       Quantity = 25
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = sesameSeed,
                       Quantity = 10
                   },
                   new BreadTypeIngredient
                   {
                       BreadTypeID = hamgurgerBun,
                       IngredientID = gilding,
                       Quantity = 5
                   }
                );



            Guid mainOffice = Guid.NewGuid();
            Guid secondOffice = Guid.NewGuid();

            modelBuilder.Entity<Office>()
              .HasData(
                new Office
                {
                    Id = mainOffice,
                    Name = "MAIN OFFICE",
                    Direcction = "742 Evergreen Terrace",
                    Phone = "664 123 456",
                    Capacity = 150,
                },
                new Office
                {
                    Id = secondOffice,
                    Name = "SECOND OFFICE",
                    Direcction = "P Sherman, 42 Wallaby Sydney",
                    Phone = "664 123 456",
                    Capacity = 100,
                }
                );

            modelBuilder.Entity<Menu>()
              .HasData(
                new Menu { 
                    OfficeID = mainOffice,
                    BreadTypeID = baguette
                },
                new Menu
                {
                    OfficeID = mainOffice,
                    BreadTypeID = whiteBread
                },
                new Menu
                {
                    OfficeID = mainOffice,
                    BreadTypeID = milkBread
                },
                new Menu
                {
                    OfficeID = secondOffice,
                    BreadTypeID = baguette
                },
                new Menu
                {
                    OfficeID = secondOffice,
                    BreadTypeID = whiteBread
                },
                new Menu
                {
                    OfficeID = secondOffice,
                    BreadTypeID = hamgurgerBun
                }
                );

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