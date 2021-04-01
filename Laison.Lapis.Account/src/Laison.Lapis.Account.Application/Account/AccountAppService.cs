using Laison.Lapis.Account.Application.Contracts;
using Laison.Lapis.Account.Domain.Entities;
using Laison.Lapis.Account.Domain.IRepositories;
using Laison.Lapis.Identity.Domain.IRepositories;
using System;
using System.Threading.Tasks;
using Volo.Abp.Uow;

namespace Laison.Lapis.Account.Application
{
    /// <summary>
    /// 账号应用服务
    /// </summary>
    public class AccountAppService : AccountAppServiceBase, IAccountAppService
    {
        private readonly IUserRepository _userRepository;

        public AccountAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserDto> LoginAsync(LoginDto input)
        {
            throw new NotImplementedException();
        }

        public Task ResetPasswordAsync(ResetPasswordDto input)
        {
            throw new NotImplementedException();
        }
    }
}