using Laison.Lapis.SettingManagement.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.SettingManagement.Application.Contracts
{
    [DependsOn(
        typeof(LapisSettingManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LapisSettingManagementApplicationContractsModule : AbpModule
    {
    }
}