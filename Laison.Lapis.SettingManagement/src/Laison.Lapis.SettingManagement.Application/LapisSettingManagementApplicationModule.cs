using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.SettingManagement.Domain;
using Laison.Lapis.SettingManagement.Application.Contracts;

namespace Laison.Lapis.SettingManagement.Application
{
    [DependsOn(
        typeof(LapisSettingManagementDomainModule),
        typeof(LapisSettingManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LapisSettingManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisSettingManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisSettingManagementApplicationModule>(validate: true);
            });
        }
    }
}
