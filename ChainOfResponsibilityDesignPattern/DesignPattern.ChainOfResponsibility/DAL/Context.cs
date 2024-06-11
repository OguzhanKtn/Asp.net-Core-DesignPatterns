using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S5STNHF;initial catalog = DesignPattern1; integrated security = true; trustServerCertificate = true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
