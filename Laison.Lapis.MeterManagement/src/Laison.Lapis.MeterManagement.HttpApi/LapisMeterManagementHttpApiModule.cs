using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.MeterManagement.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.Lapis.MeterManagement.HttpApi
{
    [DependsOn(
        typeof(LapisMeterManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LapisMeterManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LapisMeterManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}