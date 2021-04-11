using Volo.Abp.Application.Services;

namespace Laison.Lapis.MeterManagement.Application
{
    public abstract class MeterManagementAppServiceBase : ApplicationService
    {
        protected MeterManagementAppServiceBase()
        {
            ObjectMapperContext = typeof(LapisMeterManagementApplicationModule);
        }
    }
}
