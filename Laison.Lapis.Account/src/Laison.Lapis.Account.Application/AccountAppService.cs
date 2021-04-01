using Volo.Abp.Application.Services;

namespace Laison.Lapis.Account.Application
{
    public abstract class AccountAppService : ApplicationService
    {
        protected AccountAppService()
        {
            ObjectMapperContext = typeof(AccountApplicationModule);
        }
    }
}
