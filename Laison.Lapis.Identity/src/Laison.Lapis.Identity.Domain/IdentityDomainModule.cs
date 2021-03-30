using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(IdentityDomainSharedModule)
    )]
    public class IdentityDomainModule : AbpModule
    {

    }
}
