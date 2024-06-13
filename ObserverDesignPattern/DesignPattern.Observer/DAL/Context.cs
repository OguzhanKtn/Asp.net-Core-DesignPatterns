using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
    }
}
