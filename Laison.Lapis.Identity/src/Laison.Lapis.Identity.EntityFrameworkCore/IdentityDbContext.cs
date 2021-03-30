using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Identity.Domain;
using Laison.Lapis.Identity.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    [ConnectionStringName(IdentityDbProperties.ConnectionStringName)]
    public class IdentityDbContext : AbpDbContext<IdentityDbContext>, IIdentityDbContext
    {
        // Add DbSet for each Aggregate Root
        public DbSet<User> Orders { get; set; }  // Todo: get or set ?

        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureIdentity();
        }
    }
}