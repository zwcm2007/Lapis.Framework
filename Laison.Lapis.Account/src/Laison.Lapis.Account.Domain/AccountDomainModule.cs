using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AccountDomainSharedModule)
    )]
    public class AccountDomainModule : AbpModule
    {

    }
}
