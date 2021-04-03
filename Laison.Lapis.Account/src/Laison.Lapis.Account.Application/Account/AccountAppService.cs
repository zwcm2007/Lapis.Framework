using Laison.Lapis.Account.Application.Contracts;
using Laison.Lapis.Account.Domain;
using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using System;
using System.Threading.Tasks;
using Volo.Abp;

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

        public async Task<UserLoginOutput> LoginAsync(UserLoginInput input)
        {
            var user = await _userRepository.FindByUserNameAsync(input.UserName);
            if (user == null)
            {
                throw new UserFriendlyException("登录用户不存在", AccountErrorCodes.UserNotExist);
            }

            if (!user.CheckPassword(input.Password.ToMd5()))
            {
                throw new UserFriendlyException("密码不正确", AccountErrorCodes.LoginPasswordError);
            }

            return new UserLoginOutput
            {
                AccessToken = JwtHelper.GenerateToken(user, Configuration),
                Profile = ObjectMapper.Map<User, ProfileDto>(user)
            };
        }

        public Task ResetPasswordAsync(ResetPasswordDto input)
        {
            throw new NotImplementedException();
        }
    }
}