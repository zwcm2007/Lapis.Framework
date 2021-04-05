using Microsoft.Extensions.Configuration;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Shared.Application
{
    /// <summary>
    /// 应用服务基类
    /// </summary>
    public abstract class LapisAppService : ApplicationService
    {
        protected IConfiguration Configuration => LazyServiceProvider.LazyGetRequiredService<IConfiguration>();

        protected LapisAppService()
        {
        }
    }
}