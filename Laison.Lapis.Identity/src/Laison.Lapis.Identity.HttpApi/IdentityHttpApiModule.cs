using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Identity.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Identity.HttpApi
{
    [DependsOn(
        typeof(IdentityApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class IdentityHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(IdentityHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}