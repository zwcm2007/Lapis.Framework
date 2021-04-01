using Laison.Lapis.Shared.Host;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Host
{
    [DependsOn(
        typeof(LapisSharedHostModule)
        )]
    public class LapisHostModule : AbpModule
    {
        /// <summary>
        ///ConfigureServices
        /// </summary>
        /// <param name="context"></param>
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();
        }

        /// <summary>
        /// OnApplicationInitialization
        /// </summary>
        /// <param name="context"></param>
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
        }
    }
}