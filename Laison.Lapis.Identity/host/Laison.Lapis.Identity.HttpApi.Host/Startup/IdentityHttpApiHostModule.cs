using Laison.Lapis.Identity.Application;
using Laison.Lapis.Identity.EntityFrameworkCore;
using Laison.Lapis.Identity.HttpApi;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity
{
    [DependsOn(
        //typeof(LapisHostSharedModule),
        typeof(LapisIdentityApplicationModule),
        typeof(LapisIdentityEntityFrameworkCoreModule),
        typeof(LapisIdentityHttpApiModule)
        )]
    public class IdentityHttpApiHostModule : AbpModule
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