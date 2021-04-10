using Laison.Lapis.Prepayment.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    [DependsOn(
        typeof(LapisPrepaymentDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LapisPrepaymentApplicationContractsModule : AbpModule
    {
    }
}