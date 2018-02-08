using System.Data.Entity;

namespace Ecommerce.Models
{
    public class ProductContext: DbContext
    {
        public ProductContext() : base("Ecommerce")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}