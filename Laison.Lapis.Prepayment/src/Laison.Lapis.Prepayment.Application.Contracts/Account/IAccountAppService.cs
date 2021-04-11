using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<AccountDto> CreateAccountAsync(CreateAccountInput input);

        Task RechargeAccountAsync(RechargeAccountInput input);

        Task CancelAccountAsync(CancelAccountInput input);

        Task FrozenAccountAsync(FrozenAccountInput input);


    }
}