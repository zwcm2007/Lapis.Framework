using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.MeterManagement.Domain;
using Laison.Lapis.MeterManagement.Domain.Entities;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.MeterManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisMeterManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class LapisMeterManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MeterManagementDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<Order, OrderRepository>();
            });
        }
    }
}