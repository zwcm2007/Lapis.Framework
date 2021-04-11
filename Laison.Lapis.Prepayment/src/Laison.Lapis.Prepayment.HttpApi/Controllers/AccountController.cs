using Laison.Lapis.Prepayment.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
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

        public AccountController(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        /// <summary>
        // 开户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public Task<AccountDto> CreateAccountAsync(CreateAccountInput input)
        {
            return _accountAppService.CreateAccountAsync(input);
        }

        /// <summary>
        /// 销户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("cancel")]
        public Task CancelAccountAsync(CancelAccountInput input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 冻结
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("frozen")]
        public Task FrozenAccountAsync(FrozenAccountInput input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("recharge")]
        public Task RechargeAccountAsync(RechargeAccountInput input)
        {
            throw new NotImplementedException();
        }
    }
}