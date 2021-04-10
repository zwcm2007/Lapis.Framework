using Microsoft.AspNetCore.Mvc;
using Laison.Lapis.Prepayment.Application.Contracts;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.Prepayment.HttpApi
{
    [RemoteService]
    [Route("api/prepayment/account")]
    public class AccountController : PrepaymentControllerBase, IAccountAppService
    {
        private readonly IAccountAppService _accountAppService;

        public AccountController(IAccountAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        public Task<AccountDto> CreateAccountAsync(CreateAccountInput input)
        {
            throw new NotImplementedException();
        }
    }
}