using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.Prepayment.Domain;
using Laison.Lapis.Prepayment.Application.Contracts;

namespace Laison.Lapis.Prepayment.Application
{
    [DependsOn(
        typeof(LapisPrepaymentDomainModule),
        typeof(LapisPrepaymentApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LapisPrepaymentApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisPrepaymentApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisPrepaymentApplicationModule>(validate: true);
            });
        }
    }
}
