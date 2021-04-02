using Laison.Lapis.Identity.Application.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.Identity.HttpApi
{
    [RemoteService]
    [Route("api/identity/users")]
    public class UserController : IdentityControllerBase, IUserAppService
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public Task<UserDto> FindByUsernameAsync(string userName)
        {
            return _userAppService.FindByUsernameAsync(userName);
        }

        [HttpPost]
        public Task CreateUserAsync([FromBody] CreateUserInput input)
        {
            return _userAppService.CreateUserAsync(input);
        }
    }
}