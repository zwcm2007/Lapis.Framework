using Laison.Lapis.Identity.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity.Application.Contracts
{
    [DependsOn(
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule),
        typeof(LapisIdentityDomainSharedModule)
        )]
    public class LapisIdentityApplicationContractsModule : AbpModule
    {
    }
}