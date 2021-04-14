using Laison.Lapis.PermissionManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    [ConnectionStringName(PermissionManagementDbProperties.ConnectionStringName)]
    public interface IPermissionManagementDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<PermissionGrant> PermissionGrants { get; }
    }
}