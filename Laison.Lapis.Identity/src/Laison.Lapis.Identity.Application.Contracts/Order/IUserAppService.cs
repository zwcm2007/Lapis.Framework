using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Identity.Application.Contracts
{
    public interface IUserAppService : IApplicationService
    {
        Task<UserDto> GetOrderDetailsAsync(Guid id);

        Task CreateOrderAsync(CreateUserInput input);
    }
}