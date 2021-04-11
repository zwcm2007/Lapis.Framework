using Laison.Lapis.Prepayment.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Laison.Lapis.Prepayment.HttpApi
{
    [RemoteService]
    [Route("api/prepayment/customer")]
    public class CustomerController : PrepaymentControllerBase, ICustomerAppService
    {
        private readonly ICustomerAppService _accountAppService;

        public CustomerController(ICustomerAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }
    }
}