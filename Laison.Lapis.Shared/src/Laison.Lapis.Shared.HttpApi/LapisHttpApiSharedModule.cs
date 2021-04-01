using Laison.Lapis.Shared;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Shared.HttpApi
{
    [DependsOn(
      typeof(LapisSharedModule)
    )]
    public class LapisHttpApiSharedModule : AbpModule
    {
    }
}