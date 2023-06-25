using Microsoft.EntityFrameworkCore;
using ShoppingCart.Shared;

namespace ShoppingCart.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Category> Products { get; set; }
    }
}
