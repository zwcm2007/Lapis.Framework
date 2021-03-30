using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Demo.Domain;
using Laison.Lapis.Demo.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Demo.EntityFrameworkCore
{
    [ConnectionStringName(DemoDbProperties.ConnectionStringName)]
    public interface IDemoDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<Order> Orders { get; }
        
    }
}
