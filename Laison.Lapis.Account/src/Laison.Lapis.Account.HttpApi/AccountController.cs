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

        public Task<UserDto> LoginAsync(LoginDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task ResetPasswordAsync(ResetPasswordDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}