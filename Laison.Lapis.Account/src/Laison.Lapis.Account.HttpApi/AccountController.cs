using Laison.Lapis.Account.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Laison.Lapis.Account.HttpApi
{
    [RemoteService]
    [Route("api/account")]
    public class AccountController : AbpController, IAccountAppService
    {
        private readonly IAccountAppService _accountAppService;

        public AccountController(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        [HttpPost]
        [Route("login")]
        public Task<UserLoginOutput> LoginAsync(UserLoginInput input)
        {
            return _accountAppService.LoginAsync(input);
        }

        [HttpPost]
        [Route("reset-password")]
        public Task ResetPasswordAsync(ResetPasswordDto input)
        {
            return _accountAppService.ResetPasswordAsync(input);
        }
    }
}