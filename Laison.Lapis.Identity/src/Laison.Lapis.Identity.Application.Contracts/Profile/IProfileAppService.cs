using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.Identity.Application.Contracts
{
    public interface IProfileAppService : IApplicationService
    {
        Task<ProfileDto> GetAsync();

        Task<ProfileDto> UpdateAsync(UpdateProfileDto input);

        Task ChangePasswordAsync(ChangePasswordInput input);
    }
}