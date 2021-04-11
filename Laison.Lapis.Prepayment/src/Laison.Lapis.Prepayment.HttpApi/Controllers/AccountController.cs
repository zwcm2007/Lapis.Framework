﻿using Microsoft.AspNetCore.Mvc;
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

        public AccountController(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        public Task CancelAccountAsync(CancelAccountInput input)
        {
            throw new NotImplementedException();
        }

        public Task<AccountDto> CreateAccountAsync(CreateAccountInput input)
        {
            throw new NotImplementedException();
        }

        public Task RechargeAccountAsync(RechargeAccountInput input)
        {
            throw new NotImplementedException();
        }
    }
}