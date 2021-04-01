using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LapisIdentityDomainSharedModule)
    )]
    public class LapisIdentityDomainModule : AbpModule
    {

    }
}
