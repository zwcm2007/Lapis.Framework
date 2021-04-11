using Microsoft.EntityFrameworkCore;
using Laison.Lapis.MeterManagement.Domain;
using Laison.Lapis.MeterManagement.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.MeterManagement.EntityFrameworkCore
{
    [ConnectionStringName(MeterManagementDbProperties.ConnectionStringName)]
    public interface IMeterManagementDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<Order> Orders { get; }
        
    }
}
