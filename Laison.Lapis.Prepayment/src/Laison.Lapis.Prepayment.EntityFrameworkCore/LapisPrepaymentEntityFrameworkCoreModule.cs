using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Prepayment.Domain;
using Laison.Lapis.Prepayment.Domain.Entities;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisPrepaymentDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class LapisPrepaymentEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PrepaymentDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<Customer, CustomerRepository>();
            });
        }
    }
}