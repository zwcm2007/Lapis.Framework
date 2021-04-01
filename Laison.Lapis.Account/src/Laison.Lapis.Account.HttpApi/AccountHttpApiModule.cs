using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.Account.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account.HttpApi
{
    [DependsOn(
        typeof(AccountApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AccountHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AccountHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}