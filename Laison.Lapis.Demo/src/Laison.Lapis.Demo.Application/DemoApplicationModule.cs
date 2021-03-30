using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.Demo.Domain;
using Laison.Lapis.Demo.Application.Contracts;

namespace Laison.Lapis.Demo.Application
{
    [DependsOn(
        typeof(DemoDomainModule),
        typeof(DemoApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class DemoApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<DemoApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<DemoApplicationModule>(validate: true);
            });
        }
    }
}
