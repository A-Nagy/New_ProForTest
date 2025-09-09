using Microsoft.EntityFrameworkCore;

namespace New_ProForTest.Data
{
    public class AppDbContext : DbContext
    {   
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Categoty> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Premission> Premissions { get; set; }

    }
}
