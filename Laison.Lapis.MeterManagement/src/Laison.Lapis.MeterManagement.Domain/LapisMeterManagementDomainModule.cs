using Laison.Lapis.MeterManagement.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.MeterManagement.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LapisMeterManagementDomainSharedModule)
    )]
    public class LapisMeterManagementDomainModule : AbpModule
    {

    }
}
