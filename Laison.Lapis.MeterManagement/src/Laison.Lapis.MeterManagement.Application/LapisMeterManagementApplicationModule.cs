using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.MeterManagement.Domain;
using Laison.Lapis.MeterManagement.Application.Contracts;

namespace Laison.Lapis.MeterManagement.Application
{
    [DependsOn(
        typeof(LapisMeterManagementDomainModule),
        typeof(LapisMeterManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LapisMeterManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisMeterManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisMeterManagementApplicationModule>(validate: true);
            });
        }
    }
}
