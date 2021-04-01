using Laison.Lapis.Account.Domain;
using Laison.Lapis.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisAccountDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(LapisIdentityEntityFrameworkCoreModule)
    )]
    public class LapisAccountEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AccountDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });
        }
    }
}