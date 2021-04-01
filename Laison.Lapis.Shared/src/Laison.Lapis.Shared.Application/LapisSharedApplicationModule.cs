using Laison.Lapis.Shared;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Shared.Application
{
    [DependsOn(
        typeof(LapisSharedModule)
    )]
    public class LapisSharedApplicationModule : AbpModule
    {
    }
}