using JetBrains.Annotations;
using Laison.Lapis.PermissionManagement.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.PermissionManagement.HttpApi
{
    [RemoteService]
    [Route("api/PermissionManagement/permissions")]
    public class PermissionController : PermissionManagementControllerBase, IPermissionAppService
    {
        private readonly IPermissionAppService _permissionAppService;

        public PermissionController(IPermissionAppService permissionAppService)
        {
            _permissionAppService = permissionAppService;
        }

        [HttpPut]
        public Task UpdateAsync([NotNull] string providerName, [NotNull] string providerKey, UpdatePermissionsDto input)
        {
            return _permissionAppService.UpdateAsync(providerName, providerKey, input);
        }
    }
}