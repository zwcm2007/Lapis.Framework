using Laison.Lapis.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.PermissionManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(PermissionManagementEntityFrameworkCoreTestModule)
        )]
    public class PermissionManagementDomainTestModule : AbpModule
    {
        
    }
}
