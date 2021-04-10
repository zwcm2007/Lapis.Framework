using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Prepayment.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Prepayment.HttpApi
{
    [DependsOn(
        typeof(LapisPrepaymentApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LapisPrepaymentHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LapisPrepaymentHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}