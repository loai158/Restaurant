using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Restaurant.Models;
using System.Reflection.Emit;

namespace Restaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingrediant> Ingrediants{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderItem> OrderItems{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductIngrediant> ProductIngrediants { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductIngrediant>()
                    .HasKey(p =>new { p.IngrediantId,p.ProductId});


            builder.Entity<Category>()
                .HasData(
                new Category { CategoryId = 1, Name = "Appitizer" },
                new Category { CategoryId = 2, Name = "Dessert" },
                new Category { CategoryId = 3, Name = "Main" },
                new Category { CategoryId = 4, Name = "Side Dish" },
                new Category { CategoryId = 5, Name = "Salad" }
                );
            builder.Entity<Ingrediant>()
                .HasData(
                new Ingrediant { IngrediantId = 1, Name = "Chicken" },
                new Ingrediant { IngrediantId = 2, Name = "Beef" },
                new Ingrediant { IngrediantId = 3, Name = "Fish" },
                new Ingrediant { IngrediantId = 4, Name = "Letto" },
                new Ingrediant { IngrediantId = 5, Name = "Mooto" },
                new Ingrediant { IngrediantId = 6, Name = "Pickels" }
                );
            builder.Entity<Product>()
                .HasData(
                new Product { ProductId = 1, Name = "Beef Steak", Description = "Beef Steak Beef Steak", Price = 150m, Stock = 100, CatgoryId = 3 },
                new Product { ProductId = 2, Name = "Chicken wings", Description = "Chicken wings Chicken wings", Price = 180m, Stock = 120, CatgoryId = 3 },
                new Product { ProductId = 3, Name = "Fish Salamon", Description = "Fish Salamon Fish Salamon", Price = 116m, Stock = 110, CatgoryId = 3 }
                );
            builder.Entity<ProductIngrediant>()
                .HasData(
                new ProductIngrediant { ProductId = 1, IngrediantId = 1 },
                new ProductIngrediant { ProductId = 1, IngrediantId = 4 },
                new ProductIngrediant { ProductId = 1, IngrediantId = 5 },
                new ProductIngrediant { ProductId = 1, IngrediantId = 6 },
                new ProductIngrediant { ProductId = 2, IngrediantId = 2 },
                new ProductIngrediant { ProductId = 2, IngrediantId = 4 },
                new ProductIngrediant { ProductId = 2, IngrediantId = 5 },
                new ProductIngrediant { ProductId = 2, IngrediantId = 6 },
                new ProductIngrediant { ProductId = 3, IngrediantId = 3 },
                new ProductIngrediant { ProductId = 3, IngrediantId = 4 },
                new ProductIngrediant { ProductId = 3, IngrediantId = 5 },
                new ProductIngrediant { ProductId = 3, IngrediantId = 6 }
                );

        }

    }
}
