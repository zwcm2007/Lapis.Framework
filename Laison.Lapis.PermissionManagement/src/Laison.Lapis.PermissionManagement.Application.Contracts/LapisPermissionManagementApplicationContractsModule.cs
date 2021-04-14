using Laison.Lapis.PermissionManagement.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.PermissionManagement.Application.Contracts
{
    [DependsOn(
        typeof(LapisPermissionManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LapisPermissionManagementApplicationContractsModule : AbpModule
    {
    }
}