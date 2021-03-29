using Laison.Lapis.Shared;
using Microsoft.Extensions.Configuration;
using Volo.Abp.AspNetCore.Mvc;

namespace Laison.Lapis.HttpApi.Shared
{
    /// <summary>
    /// 档案控制器
    /// </summary>
    public class LapisController : AbpController
    {
        protected new ICurrentUser CurrentUser => LazyGetRequiredService(ref _currentUser);
        private ICurrentUser _currentUser;

        protected IConfiguration Configuration => LazyGetRequiredService(ref _configuration);
        private IConfiguration _configuration;
    }
}