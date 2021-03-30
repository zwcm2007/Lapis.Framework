using Volo.Abp.Application.Services;

namespace Laison.Lapis.Identity.Application
{
    public abstract class IdentityAppService : ApplicationService
    {
        protected IdentityAppService()
        {
            ObjectMapperContext = typeof(IdentityApplicationModule);
        }
    }
}
