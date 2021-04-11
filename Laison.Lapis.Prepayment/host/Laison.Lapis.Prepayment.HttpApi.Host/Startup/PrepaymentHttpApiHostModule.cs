using Laison.Lapis.Prepayment.Application;
using Laison.Lapis.Prepayment.EntityFrameworkCore;
using Laison.Lapis.Prepayment.HttpApi;
using Laison.Lapis.Shared.Host;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Prepayment
{
    [DependsOn(
        typeof(LapisSharedHostModule),
        typeof(LapisPrepaymentApplicationModule),
        typeof(LapisPrepaymentEntityFrameworkCoreModule),
        typeof(LapisPrepaymentHttpApiModule)
        )]
    public class PrepaymentHttpApiHostModule : AbpModule
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
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
        }
    }
}