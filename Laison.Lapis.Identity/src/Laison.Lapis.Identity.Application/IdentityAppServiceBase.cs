using Volo.Abp.Application.Services;

namespace Laison.Lapis.Identity.Application
{
    public abstract class IdentityAppServiceBase : ApplicationService
    {
        protected IdentityAppServiceBase()
        {
            ObjectMapperContext = typeof(LapisIdentityApplicationModule);
        }
    }
}
