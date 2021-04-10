using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<AccountDto> CreateAccountAsync(CreateAccountInput input);
    }
}