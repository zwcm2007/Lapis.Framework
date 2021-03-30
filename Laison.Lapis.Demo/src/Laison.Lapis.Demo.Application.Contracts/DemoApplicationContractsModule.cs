using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Laison.Lapis.Demo.Domain;

namespace Laison.Lapis.Demo.Application.Contracts
{
    [DependsOn(
        typeof(DemoDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class DemoApplicationContractsModule : AbpModule
    {

    }
}
