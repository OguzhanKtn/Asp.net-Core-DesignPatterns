using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S5STNHF;initial catalog = DesignPattern2; integrated security = true; trustServerCertificate = true");
        }

        public DbSet<Product> Products { get; set; } 
    }
}
