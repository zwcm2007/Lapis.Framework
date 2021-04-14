using JetBrains.Annotations;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.Lapis.PermissionManagement.Application.Contracts
{
    public interface IPermissionAppService : IApplicationService
    {
        //Task<GetPermissionListResultDto> GetAsync([NotNull] string providerName, [NotNull] string providerKey);

        Task UpdateAsync([NotNull] string providerName, [NotNull] string providerKey, UpdatePermissionsDto input);

    }
}