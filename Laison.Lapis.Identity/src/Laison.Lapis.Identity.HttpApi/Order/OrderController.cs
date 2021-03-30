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
        public Task<UserDto> GetOrderDetailsAsync([FromQuery] Guid id)
        {
            return _orderAppService.GetOrderDetailsAsync(id);
        }

        [HttpPost]
        public Task CreateOrderAsync(CreateUserInput input)
        {
            return _orderAppService.CreateOrderAsync(input);
        }
    }
}