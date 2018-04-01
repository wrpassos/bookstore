using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ProductContext(DbContextOptions<ProductContext> options) : base(
            options)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public ProductContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}