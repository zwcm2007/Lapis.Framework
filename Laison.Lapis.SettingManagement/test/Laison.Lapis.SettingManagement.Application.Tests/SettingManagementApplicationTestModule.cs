using Laison.Lapis.SettingManagement.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.SettingManagement
{
    [DependsOn(
        typeof(LapisSettingManagementApplicationModule),
        typeof(SettingManagementDomainTestModule)
        )]
    public class SettingManagementApplicationTestModule : AbpModule
    {

    }
}
