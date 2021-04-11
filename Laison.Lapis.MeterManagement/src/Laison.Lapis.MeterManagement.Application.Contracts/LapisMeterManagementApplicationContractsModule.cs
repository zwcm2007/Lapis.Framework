using Laison.Lapis.MeterManagement.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.MeterManagement.Application.Contracts
{
    [DependsOn(
        typeof(LapisMeterManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LapisMeterManagementApplicationContractsModule : AbpModule
    {
    }
}