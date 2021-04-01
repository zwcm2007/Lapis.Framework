using Volo.Abp.Application.Services;

namespace Laison.Lapis.Account.Application
{
    public abstract class AccountAppServiceBase : ApplicationService
    {
        protected AccountAppServiceBase()
        {
            ObjectMapperContext = typeof(AccountApplicationModule);
        }
    }
}
