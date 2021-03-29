using Laison.Lapis.Shared;
using Volo.Abp.Modularity;

namespace Laison.Lapis.HttpApi.Shared
{
    [DependsOn(
      typeof(LapisSharedModule)
    )]
    public class LapisHttpApiSharedModule : AbpModule
    {
    }
}