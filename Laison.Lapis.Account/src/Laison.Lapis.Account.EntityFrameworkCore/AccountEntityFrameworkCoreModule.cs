using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Account.Domain;
using Laison.Lapis.Account.Domain.Entities;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    [DependsOn(
        typeof(AccountDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class AccountEntityFrameworkCoreModule : AbpModule
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