using Microsoft.Extensions.Configuration;
using Volo.Abp.AspNetCore.Mvc;

namespace Laison.Lapis.Shared.HttpApi
{
    /// <summary>
    /// LapisController
    /// </summary>
    public class LapisController : AbpController
    {
        protected IConfiguration Configuration => LazyServiceProvider.LazyGetRequiredService<IConfiguration>();
    }
}