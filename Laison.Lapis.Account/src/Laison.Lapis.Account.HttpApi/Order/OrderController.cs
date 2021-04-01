using Microsoft.AspNetCore.Mvc;
using Laison.Lapis.Account.Application.Contracts;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.Account.HttpApi
{
    [RemoteService]
    [Route("api/Account/order")]
    public class OrderController : AccountController, IOrderAppService
    {
        private readonly IOrderAppService _orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpGet]
        public Task<OrderDto> GetOrderDetailsAsync([FromQuery] Guid id)
        {
            return _orderAppService.GetOrderDetailsAsync(id);
        }

        [HttpPost]
        public Task CreateOrderAsync(CreateOrderInput input)
        {
            return _orderAppService.CreateOrderAsync(input);
        }
    }
}