using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {    
    }
    public DbSet<Client> Client { get; set; }
    public DbSet<Event> Event { get; set; }
    public DbSet<Organizer> Organizer { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Registering> Registering { get; set; }
    }
}