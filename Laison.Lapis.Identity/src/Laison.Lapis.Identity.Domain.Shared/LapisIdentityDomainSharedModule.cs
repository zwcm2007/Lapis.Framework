using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.VirtualFileSystem;

namespace Laison.Lapis.Identity.Domain
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LapisIdentityDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LapisIdentityDomainSharedModule>();
            });
        }
    }
}