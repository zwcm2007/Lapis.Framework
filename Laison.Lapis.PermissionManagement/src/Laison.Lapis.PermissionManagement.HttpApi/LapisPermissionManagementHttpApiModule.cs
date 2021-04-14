using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.PermissionManagement.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.Lapis.PermissionManagement.HttpApi
{
    [DependsOn(
        typeof(LapisPermissionManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LapisPermissionManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LapisPermissionManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}