using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.Account.Domain;
using Laison.Lapis.Account.Application.Contracts;
using Laison.Lapis.Shared.Application;
using Laison.Lapis.Identity.Domain;

namespace Laison.Lapis.Account.Application
{
    [DependsOn(
        typeof(LapisAccountDomainModule),
        typeof(LapisAccountApplicationContractsModule),
        typeof(LapisSharedApplicationModule),
        typeof(LapisIdentityDomainModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LapisAccountApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisAccountApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisAccountApplicationModule>(validate: true);
            });
        }
    }
}
