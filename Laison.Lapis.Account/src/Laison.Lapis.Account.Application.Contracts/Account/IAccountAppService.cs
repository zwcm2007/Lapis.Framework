using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Account.Application.Contracts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<UserLoginOutput> LoginAsync(UserLoginInput input);

        Task ResetPasswordAsync(ResetPasswordDto input);

        //Task SendPasswordResetCodeAsync(SendPasswordResetCodeDto input);

    }
}