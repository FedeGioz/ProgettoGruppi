using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProgettoGruppi.Areas.Identity.Data;
using ProgettoGruppi.Models;

namespace ProgettoGruppi.Data
{
    public class ProgettoGruppiDbContext : IdentityDbContext<ApplicationUser>
    {
        public ProgettoGruppiDbContext(DbContextOptions<ProgettoGruppiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Segnalazione> Segnalazioni { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
