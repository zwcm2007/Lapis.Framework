using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.VirtualFileSystem;

namespace Laison.Lapis.MeterManagement.Domain.Shared
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LapisMeterManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LapisMeterManagementDomainSharedModule>();
            });
        }
    }
}