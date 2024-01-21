using System.Data.Entity;

namespace PasoconStore.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("PasoconStore")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}