using Volo.Abp.Application.Services;

namespace Laison.Lapis.PermissionManagement.Application
{
    public abstract class PermissionManagementAppServiceBase : ApplicationService
    {
        protected PermissionManagementAppServiceBase()
        {
            ObjectMapperContext = typeof(LapisPermissionManagementApplicationModule);
        }
    }
}
