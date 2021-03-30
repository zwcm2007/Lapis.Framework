using Laison.Lapis.Identity.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity
{
    [DependsOn(
        typeof(IdentityApplicationModule),
        typeof(IdentityDomainTestModule)
        )]
    public class IdentityApplicationTestModule : AbpModule
    {

    }
}
