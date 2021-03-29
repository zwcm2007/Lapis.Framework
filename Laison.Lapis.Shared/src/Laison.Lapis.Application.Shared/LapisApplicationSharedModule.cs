using Laison.Lapis.Shared;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Application.Shared
{
    [DependsOn(
        typeof(LapisSharedModule)
    )]
    public class LapisApplicationSharedModule : AbpModule
    {
    }
}