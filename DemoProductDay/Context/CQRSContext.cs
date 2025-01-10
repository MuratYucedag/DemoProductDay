using DemoProductDay.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProductDay.Context
{
    public class CQRSContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial catalog=DbCQRSDayDemo;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
