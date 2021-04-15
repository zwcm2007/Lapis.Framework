using Laison.Lapis.PermissionManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    [ConnectionStringName(PermissionManagementDbProperties.ConnectionStringName)]
    public interface IPermissionManagementDbContext : IEfCoreDbContext
    {
        DbSet<PermissionGrant> PermissionGrants { get; }
    }
}