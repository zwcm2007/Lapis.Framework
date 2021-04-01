using Microsoft.AspNetCore.Authorization;
using Volo.Abp.AspNetCore.Mvc;

namespace Laison.Lapis.Identity.HttpApi
{
    [AllowAnonymous]
    public abstract class IdentityController : AbpController
    {
        protected IdentityController()
        {
        }
    }
}