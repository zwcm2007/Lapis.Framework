using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Account.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account.HttpApi
{
    [DependsOn(
        typeof(LapisAccountApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LapisAccountHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LapisAccountHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}