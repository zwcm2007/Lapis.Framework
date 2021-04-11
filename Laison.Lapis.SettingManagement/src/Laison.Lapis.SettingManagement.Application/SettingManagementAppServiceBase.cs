using Volo.Abp.Application.Services;

namespace Laison.Lapis.SettingManagement.Application
{
    public abstract class SettingManagementAppServiceBase : ApplicationService
    {
        protected SettingManagementAppServiceBase()
        {
            ObjectMapperContext = typeof(LapisSettingManagementApplicationModule);
        }
    }
}
