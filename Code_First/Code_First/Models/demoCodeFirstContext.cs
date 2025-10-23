using Microsoft.EntityFrameworkCore;
namespace Code_First.Models
{
    public class demoCodeFirstContext : DbContext
    {
        public demoCodeFirstContext(DbContextOptions<demoCodeFirstContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
