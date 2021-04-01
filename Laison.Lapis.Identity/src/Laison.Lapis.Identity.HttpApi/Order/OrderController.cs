using Microsoft.AspNetCore.Mvc;
using Laison.Lapis.Identity.Application.Contracts;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.Identity.HttpApi
{
    [RemoteService]
    [Route("api/Identity/order")]
    public class OrderController : IdentityController, IUserAppService
    {
        private readonly IUserAppService _orderAppService;

        public OrderController(IUserAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpGet]
        public Task<UserDto> GetUserDetailsAsync([FromQuery] Guid id)
        {
            return _orderAppService.GetUserDetailsAsync(id);
        }

        [HttpPost]
        public Task CreateUserAsync(CreateUserInput input)
        {
            return _orderAppService.CreateUserAsync(input);
        }
    }
}