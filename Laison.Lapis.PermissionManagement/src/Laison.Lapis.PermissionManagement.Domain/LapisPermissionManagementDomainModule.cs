using Laison.Lapis.PermissionManagement.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.PermissionManagement.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LapisPermissionManagementDomainSharedModule)
    )]
    public class LapisPermissionManagementDomainModule : AbpModule
    {

    }
}
