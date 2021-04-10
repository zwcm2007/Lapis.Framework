using Laison.Lapis.Prepayment.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Prepayment
{
    [DependsOn(
        typeof(LapisPrepaymentApplicationModule),
        typeof(PrepaymentDomainTestModule)
        )]
    public class PrepaymentApplicationTestModule : AbpModule
    {

    }
}
