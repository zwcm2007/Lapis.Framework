using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Laison.Lapis.Account.Domain;

namespace Laison.Lapis.Account.Application.Contracts
{
    [DependsOn(
        typeof(AccountDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LapisAccountApplicationContractsModule : AbpModule
    {

    }
}
