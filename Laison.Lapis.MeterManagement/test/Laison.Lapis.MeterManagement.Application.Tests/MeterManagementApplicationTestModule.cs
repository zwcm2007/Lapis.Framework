using Laison.Lapis.MeterManagement.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.MeterManagement
{
    [DependsOn(
        typeof(LapisMeterManagementApplicationModule),
        typeof(MeterManagementDomainTestModule)
        )]
    public class MeterManagementApplicationTestModule : AbpModule
    {

    }
}
