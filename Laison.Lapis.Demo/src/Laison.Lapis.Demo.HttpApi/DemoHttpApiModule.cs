using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Demo.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Demo.HttpApi
{
    [DependsOn(
        typeof(DemoApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class DemoHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(DemoHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}