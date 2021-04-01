using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.Identity.Domain;
using Laison.Lapis.Identity.Application.Contracts;

namespace Laison.Lapis.Identity.Application
{
    [DependsOn(
        typeof(LapisIdentityDomainModule),
        typeof(LapisIdentityApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LapisIdentityApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisIdentityApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisIdentityApplicationModule>(validate: true);
            });
        }
    }
}
