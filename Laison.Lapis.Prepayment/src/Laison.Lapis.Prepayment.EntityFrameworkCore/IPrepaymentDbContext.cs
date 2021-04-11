using Laison.Lapis.Prepayment.Domain;
using Laison.Lapis.Prepayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    [ConnectionStringName(PrepaymentDbProperties.ConnectionStringName)]
    public interface IPrepaymentDbContext : IEfCoreDbContext
    {
        DbSet<Account> Accounts { get; }
        DbSet<Customer> Customers { get; }
        DbSet<RegisterTradeDetail> RegisterTradeDetails { get; }
        DbSet<RechargeTradeDetail> RechargeTradeDetails { get; }
    }
}