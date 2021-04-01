using Laison.Lapis.Shared.Application;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Account.Application
{
    public abstract class AccountAppServiceBase : LapisAppService
    {
        protected AccountAppServiceBase()
        {
            ObjectMapperContext = typeof(AccountApplicationModule);
        }
    }
}
