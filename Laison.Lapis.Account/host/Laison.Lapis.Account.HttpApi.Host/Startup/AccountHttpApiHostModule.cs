using Laison.Lapis.Account.Application;
using Laison.Lapis.Account.EntityFrameworkCore;
using Laison.Lapis.Account.HttpApi;
using Laison.Lapis.Shared.Host;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account
{
    [DependsOn(
        typeof(LapisSharedHostModule),
        typeof(LapisAccountApplicationModule),
        typeof(LapisAccountEntityFrameworkCoreModule),
        typeof(LapisAccountHttpApiModule)
        )]
    public class AccountHttpApiHostModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseMySQL();
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
        }
    }
}