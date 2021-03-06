using Laison.Lapis.Identity.Application;
using Laison.Lapis.Identity.EntityFrameworkCore;
using Laison.Lapis.Identity.HttpApi;
using Laison.Lapis.Shared.Host;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace Laison.Lapis.Identity
{
    [DependsOn(
        typeof(LapisSharedHostModule),
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

            //Configure<AbpSettingOptions>(options =>
            //{
            //    options.DefinitionProviders.Clear();
            //    options.DefinitionProviders.Add<DefaultLangSettingDefinitionProvider>(); 
            //});
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
        }
    }
}