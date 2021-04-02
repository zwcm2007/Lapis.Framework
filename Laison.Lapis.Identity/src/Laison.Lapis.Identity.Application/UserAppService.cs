using Laison.Lapis.Identity.Application.Contracts;
using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using System;
using System.Threading.Tasks;
using Volo.Abp.Uow;

namespace Laison.Lapis.Identity.Application
{
    /// <summary>
    /// 用户应用服务
    /// </summary>
    public class UserAppService : IdentityAppServiceBase, IUserAppService
    {
        private readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [UnitOfWork]
        public async Task CreateUserAsync(CreateUserInput input)
        {
            var user = new User(GuidGenerator.Create(), input.Name, input.UserName,
                input.Email,
                input.Sex,
                input.PhoneNumber);

            await _userRepository.InsertAsync(user);
        }

        public Task<RoleDto> GetUserDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}