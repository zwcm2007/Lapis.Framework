using Laison.Lapis.PermissionManagement.Domain;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisPermissionManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class LapisPermissionManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PermissionManagementDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<PermissionGrant, PermissionGrantRepository>();
            });
        }
    }
}