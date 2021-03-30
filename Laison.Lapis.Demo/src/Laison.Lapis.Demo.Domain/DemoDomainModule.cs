using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Demo.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(DemoDomainSharedModule)
    )]
    public class DemoDomainModule : AbpModule
    {

    }
}
