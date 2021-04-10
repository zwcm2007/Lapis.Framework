using Laison.Lapis.Prepayment.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Prepayment.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LapisPrepaymentDomainSharedModule)
    )]
    public class LapisPrepaymentDomainModule : AbpModule
    {

    }
}
