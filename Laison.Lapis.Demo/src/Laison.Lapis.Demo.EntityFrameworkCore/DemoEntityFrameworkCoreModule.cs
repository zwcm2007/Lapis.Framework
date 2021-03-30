using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Demo.Domain;
using Laison.Lapis.Demo.Domain.Entities;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Demo.EntityFrameworkCore
{
    [DependsOn(
        typeof(DemoDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class DemoEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DemoDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<Order, OrderRepository>();
            });
        }
    }
}