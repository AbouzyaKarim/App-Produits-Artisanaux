using Artisanaux.Service.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Artisanaux.Service.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        /// <summary>
        /// options + echantillon (DBSET)
        /// </summary>
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdProduct = 1,
                ProductName="Product1",
                Price=15,
                CategoryName="Categorie1",
                ImageURL= "https://artisanaka.blob.core.windows.net/artisana/1.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdProduct = 2,
                ProductName = "Product2",
                Price = 65,
                CategoryName = "Categorie2",
                ImageURL = "https://artisanaka.blob.core.windows.net/artisana/2.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdProduct = 3,
                ProductName = "Product3",
                Price = 45,
                CategoryName = "Categorie3",
                ImageURL = "https://artisanaka.blob.core.windows.net/artisana/3.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdProduct = 4,
                ProductName = "Product4",
                Price = 20,
                CategoryName = "Categorie4",
                ImageURL = "https://artisanaka.blob.core.windows.net/artisana/4.jpg"
            });
        }
    }
}
