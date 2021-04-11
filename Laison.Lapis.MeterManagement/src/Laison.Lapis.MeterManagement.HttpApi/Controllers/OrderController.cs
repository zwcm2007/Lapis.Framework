using Microsoft.AspNetCore.Mvc;
using Laison.Lapis.MeterManagement.Application.Contracts;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.MeterManagement.HttpApi
{
    [RemoteService]
    [Route("api/MeterManagement/order")]
    public class OrderController : MeterManagementControllerBase, IOrderAppService
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