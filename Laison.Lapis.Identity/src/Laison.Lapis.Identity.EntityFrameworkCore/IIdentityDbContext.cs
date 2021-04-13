using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Identity.Domain;
using Laison.Lapis.Identity.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    [ConnectionStringName(IdentityDbProperties.ConnectionStringName)]
    public interface IIdentityDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<User> Users { get; }
        DbSet<Role> Roles { get; }
        DbSet<Organization> Organizations { get; }
    }
}
