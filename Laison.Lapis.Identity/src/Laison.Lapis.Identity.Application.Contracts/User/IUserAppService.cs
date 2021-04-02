using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Identity.Application.Contracts
{
    public interface IUserAppService : IApplicationService
    {
        Task<UserDto> FindByUsernameAsync(string userName);

        Task CreateUserAsync(CreateUserInput input);


    }
}