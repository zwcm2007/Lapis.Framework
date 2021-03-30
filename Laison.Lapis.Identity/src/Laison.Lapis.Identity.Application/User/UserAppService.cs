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
    public class UserAppService : IdentityAppService, IUserAppService
    {
        private readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [UnitOfWork]
        public async Task CreateOrderAsync(CreateUserInput input)
        {
            var order = new User(GuidGenerator.Create(), input.Name);
            await _userRepository.InsertAsync(order);
        }

        public Task<UserDto> GetOrderDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}