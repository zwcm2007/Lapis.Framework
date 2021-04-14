using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.PermissionManagement.Domain;
using Laison.Lapis.PermissionManagement.Application.Contracts;

namespace Laison.Lapis.PermissionManagement.Application
{
    [DependsOn(
        typeof(LapisPermissionManagementDomainModule),
        typeof(LapisPermissionManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LapisPermissionManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisPermissionManagementApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisPermissionManagementApplicationModule>(validate: true);
            });
        }
    }
}
