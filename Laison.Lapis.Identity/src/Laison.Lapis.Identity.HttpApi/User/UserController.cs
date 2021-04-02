using Laison.Lapis.Identity.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.Identity.HttpApi
{
    [RemoteService]
    [Route("api/Identity/user")]
    public class UserController : IdentityController, IUserAppService
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public Task<RoleDto> GetUserDetailsAsync([FromQuery] Guid id)
        {
            return _userAppService.GetUserDetailsAsync(id);
        }

        [HttpPost]
        public Task CreateUserAsync(CreateUserInput input)
        {
            return _userAppService.CreateUserAsync(input);
        }
    }
}