using Microsoft.EntityFrameworkCore;
using Laison.Lapis.SettingManagement.Domain;
using Laison.Lapis.SettingManagement.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.SettingManagement.EntityFrameworkCore
{
    [ConnectionStringName(SettingManagementDbProperties.ConnectionStringName)]
    public interface ISettingManagementDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<Order> Orders { get; }
        
    }
}
