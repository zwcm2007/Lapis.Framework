using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Laison.Lapis.Identity.Domain;

namespace Laison.Lapis.Identity.Application.Contracts
{
    [DependsOn(
        typeof(IdentityDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class IdentityApplicationContractsModule : AbpModule
    {

    }
}
