using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S5STNHF;initial catalog = DesignPattern4; integrated security = true; trustServerCertificate = true");
        }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
