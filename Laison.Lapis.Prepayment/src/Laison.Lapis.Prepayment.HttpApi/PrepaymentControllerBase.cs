using Microsoft.AspNetCore.Authorization;
using Volo.Abp.AspNetCore.Mvc;

namespace Laison.Lapis.Prepayment.HttpApi
{
    [Authorize]
    public abstract class PrepaymentControllerBase : AbpController
    {
        protected PrepaymentControllerBase()
        {
        }
    }
}