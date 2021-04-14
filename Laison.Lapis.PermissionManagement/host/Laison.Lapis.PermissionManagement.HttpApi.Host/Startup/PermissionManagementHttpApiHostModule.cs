using Laison.Lapis.PermissionManagement.Application;
using Laison.Lapis.PermissionManagement.EntityFrameworkCore;
using Laison.Lapis.PermissionManagement.HttpApi;
using Laison.Lapis.Shared.Host;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;

namespace Laison.Lapis.PermissionManagement
{
    [DependsOn(
        typeof(LapisSharedHostModule),
        typeof(LapisPermissionManagementApplicationModule),
        typeof(LapisPermissionManagementEntityFrameworkCoreModule),
        typeof(LapisPermissionManagementHttpApiModule)
        )]
    public class PermissionManagementHttpApiHostModule : AbpModule
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