using Laison.Lapis.MeterManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.MeterManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(MeterManagementEntityFrameworkCoreTestModule)
        )]
    public class MeterManagementDomainTestModule : AbpModule
    {
        
    }
}
