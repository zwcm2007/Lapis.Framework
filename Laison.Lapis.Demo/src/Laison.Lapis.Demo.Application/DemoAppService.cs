using Volo.Abp.Application.Services;

namespace Laison.Lapis.Demo.Application
{
    public abstract class DemoAppService : ApplicationService
    {
        protected DemoAppService()
        {
            ObjectMapperContext = typeof(DemoApplicationModule);
        }
    }
}
