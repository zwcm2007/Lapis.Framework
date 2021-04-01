using Laison.Lapis.Identity.Domain;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LapisAccountDomainSharedModule),
        typeof(LapisIdentityDomainModule)
    )]
    public class LapisAccountDomainModule : AbpModule
    {

    }
}
