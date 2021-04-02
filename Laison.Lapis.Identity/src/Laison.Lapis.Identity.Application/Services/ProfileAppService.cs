using Laison.Lapis.Identity.Application.Contracts;
using Laison.Lapis.Identity.Domain.IRepositories;
using System;
using System.Threading.Tasks;

namespace Laison.Lapis.Identity.Application
{
    /// <summary>
    /// 简介应用服务
    /// </summary>
    public class ProfileAppService : IdentityAppServiceBase, IProfileAppService
    {
        private readonly IUserRepository _userRepository;

        public ProfileAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task ChangePasswordAsync(ChangePasswordInput input)
        {
            var user = await _userRepository.FindAsync(CurrentUser.Id.Value);

            user.ChangePassword(input.CurrentPassword.ToMd5(), input.NewPassword.ToMd5());
        }

        public Task<ProfileDto> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProfileDto> UpdateAsync(UpdateProfileDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}