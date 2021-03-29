using Laison.Lapis.Shared;
using Microsoft.Extensions.Configuration;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Application.Shared
{
    /// <summary>
    /// 应用服务基类
    /// </summary>
    public abstract class ArchiveAppService : ApplicationService
    {
        protected new ICurrentUser CurrentUser => LazyGetRequiredService(ref _currentUser);
        private ICurrentUser _currentUser;

        protected IConfiguration Configuration => LazyGetRequiredService(ref _configuration);
        private IConfiguration _configuration;

        protected ArchiveAppService()
        {
        }
    }
}