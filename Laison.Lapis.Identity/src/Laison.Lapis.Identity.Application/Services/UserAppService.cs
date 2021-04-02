using Laison.Lapis.Identity.Application.Contracts;
using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using System.Threading.Tasks;
using Volo.Abp.Data;
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
            var user = new User(GuidGenerator.Create(), input.UserName, "123456",
                input.Name,
                input.Email,
                input.Sex,
                input.PhoneNumber);

            user.SetProperty("surname", "冯");
            user.SetProperty("Country", "China");

            await _userRepository.InsertAsync(user);
        }

        public async Task<UserDto> FindByUsernameAsync(string userName)
        {
            var user = await _userRepository.FindByUserNameAsync(userName);
            return ObjectMapper.Map<User, UserDto>(user);
        }
    }
}