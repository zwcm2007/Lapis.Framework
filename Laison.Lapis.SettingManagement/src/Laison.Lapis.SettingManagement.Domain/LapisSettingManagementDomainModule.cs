using Laison.Lapis.SettingManagement.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.SettingManagement.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LapisSettingManagementDomainSharedModule)
    )]
    public class LapisSettingManagementDomainModule : AbpModule
    {

    }
}
