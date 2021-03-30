using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.Identity.Domain;
using Laison.Lapis.Identity.Application.Contracts;

namespace Laison.Lapis.Identity.Application
{
    [DependsOn(
        typeof(IdentityDomainModule),
        typeof(IdentityApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class IdentityApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<IdentityApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<IdentityApplicationModule>(validate: true);
            });
        }
    }
}
