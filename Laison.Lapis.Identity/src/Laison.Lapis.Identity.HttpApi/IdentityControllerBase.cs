using Microsoft.AspNetCore.Authorization;
using Volo.Abp.AspNetCore.Mvc;

namespace Laison.Lapis.Identity.HttpApi
{
    public abstract class IdentityControllerBase : AbpController
    {
        protected IdentityControllerBase()
        {
        }
    }
}