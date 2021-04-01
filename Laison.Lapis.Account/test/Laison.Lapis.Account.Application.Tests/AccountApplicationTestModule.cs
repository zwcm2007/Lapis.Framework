using Laison.Lapis.Account.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.Account
{
    [DependsOn(
        typeof(LapisAccountApplicationModule),
        typeof(AccountDomainTestModule)
        )]
    public class AccountApplicationTestModule : AbpModule
    {

    }
}
