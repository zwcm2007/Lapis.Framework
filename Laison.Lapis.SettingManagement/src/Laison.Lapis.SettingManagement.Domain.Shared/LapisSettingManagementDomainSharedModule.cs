using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.VirtualFileSystem;

namespace Laison.Lapis.SettingManagement.Domain.Shared
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LapisSettingManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LapisSettingManagementDomainSharedModule>();
            });
        }
    }
}