using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Identity.Domain;
using Laison.Lapis.Identity.Domain.Entities;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    [DependsOn(
        typeof(IdentityDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class IdentityEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<IdentityDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<Order, OrderRepository>();
            });
        }
    }
}