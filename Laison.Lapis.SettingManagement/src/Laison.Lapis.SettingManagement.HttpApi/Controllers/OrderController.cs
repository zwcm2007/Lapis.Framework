using Microsoft.AspNetCore.Mvc;
using Laison.Lapis.SettingManagement.Application.Contracts;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.SettingManagement.HttpApi
{
    [RemoteService]
    [Route("api/SettingManagement/order")]
    public class OrderController : SettingManagementControllerBase, IOrderAppService
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