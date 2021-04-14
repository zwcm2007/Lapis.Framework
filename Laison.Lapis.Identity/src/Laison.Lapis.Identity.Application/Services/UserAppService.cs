using Laison.Lapis.Identity.Application.Contracts;
using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using Laison.Lapis.Identity.Domain.Shared;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using Volo.Abp.Localization;
using Volo.Abp.Settings;
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

        [Authorize(IdentityPermissions.Users.Create)]
        public async Task CreateUserAsync(CreateUserInput input)
        {
            var user = new User(GuidGenerator.Create(),
                input.UserName,
                UserConsts.DefaultInitPassword.ToMd5(),
                input.Name,
                input.Email,
                input.Sex,
                input.PhoneNumber);

            await _userRepository.InsertAsync(user);
        }

        public async Task<UserDto> FindByUsernameAsync(string userName)
        {

            var c = await base.SettingProvider.GetOrNullAsync(LocalizationSettingNames.DefaultLanguage);

            var a  = ServiceProvider.GetService(typeof(ISettingDefinitionContext));

            var b =  L["SamplePageMessage"];

            var user = await _userRepository.FindByUserNameAsync(userName);
            return ObjectMapper.Map<User, UserDto>(user);
        }
    }
}