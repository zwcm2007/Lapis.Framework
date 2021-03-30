using Laison.Lapis.Demo.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Demo
{
    [DependsOn(
        typeof(DemoApplicationModule),
        typeof(DemoDomainTestModule)
        )]
    public class DemoApplicationTestModule : AbpModule
    {

    }
}
