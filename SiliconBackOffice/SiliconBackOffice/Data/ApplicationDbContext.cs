using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SiliconBackOffice.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<AddressModel> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AddressModel>()
                .HasMany(a => a.Users)
                .WithOne(u => u.Address)
                .HasForeignKey(u => u.AddressId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
