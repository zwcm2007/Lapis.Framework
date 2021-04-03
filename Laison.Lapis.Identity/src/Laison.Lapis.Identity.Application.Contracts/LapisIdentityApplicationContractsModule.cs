using Laison.Lapis.Identity.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity.Application.Contracts
{
    [DependsOn(
        typeof(LapisIdentityDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LapisIdentityApplicationContractsModule : AbpModule
    {
    }
}