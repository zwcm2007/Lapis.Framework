using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.VirtualFileSystem;

namespace Laison.Lapis.Demo.Domain
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class DemoDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<DemoDomainSharedModule>();
            });
        }
    }
}