using Laison.Lapis.Account.Domain;
using Laison.Lapis.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisIdentityEntityFrameworkCoreModule),
        typeof(LapisAccountDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class LapisAccountEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            
        }
    }
}