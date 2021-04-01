using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.VirtualFileSystem;

namespace Laison.Lapis.Account.Domain
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LapisAccountDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LapisAccountDomainSharedModule>();
            });
        }
    }
}