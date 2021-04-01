using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Account.Domain;
using Laison.Lapis.Account.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    [ConnectionStringName(AccountDbProperties.ConnectionStringName)]
    public interface IAccountDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<Order> Orders { get; }
        
    }
}
