using Laison.Lapis.PermissionManagement.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.PermissionManagement
{
    [DependsOn(
        typeof(LapisPermissionManagementApplicationModule),
        typeof(PermissionManagementDomainTestModule)
        )]
    public class PermissionManagementApplicationTestModule : AbpModule
    {

    }
}
