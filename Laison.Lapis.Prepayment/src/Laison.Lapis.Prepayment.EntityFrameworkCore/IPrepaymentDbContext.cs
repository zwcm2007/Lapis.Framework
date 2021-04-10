using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Prepayment.Domain;
using Laison.Lapis.Prepayment.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    [ConnectionStringName(PrepaymentDbProperties.ConnectionStringName)]
    public interface IPrepaymentDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<Trade> Orders { get; }
        
    }
}
