using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.VirtualFileSystem;

namespace Laison.Lapis.Prepayment.Domain.Shared
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LapisPrepaymentDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LapisPrepaymentDomainSharedModule>();
            });
        }
    }
}