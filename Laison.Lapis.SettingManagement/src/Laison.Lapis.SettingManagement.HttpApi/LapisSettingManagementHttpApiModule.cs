using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.SettingManagement.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.Lapis.SettingManagement.HttpApi
{
    [DependsOn(
        typeof(LapisSettingManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LapisSettingManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LapisSettingManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}