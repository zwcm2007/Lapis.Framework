using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.SettingManagement.Domain;
using Laison.Lapis.SettingManagement.Domain.Entities;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.SettingManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisSettingManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class LapisSettingManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SettingManagementDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<Order, OrderRepository>();
            });
        }
    }
}