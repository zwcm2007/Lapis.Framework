using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.MeterManagement.Application.Contracts
{
    public interface IOrderAppService : IApplicationService
    {
        Task<OrderDto> GetOrderDetailsAsync(Guid id);

        Task CreateOrderAsync(CreateOrderInput input);
    }
}