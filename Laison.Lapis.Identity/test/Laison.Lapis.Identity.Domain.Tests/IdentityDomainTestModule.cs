using Laison.Lapis.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(IdentityEntityFrameworkCoreTestModule)
        )]
    public class IdentityDomainTestModule : AbpModule
    {
        
    }
}
