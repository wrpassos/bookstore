using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(
            options)
        {
        }

        public ProductContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}