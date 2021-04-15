using Laison.Lapis.PermissionManagement.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.Lapis.PermissionManagement.HttpApi
{
    [RemoteService]
    [Route("api/permission-management/permissions")]
    public class PermissionController : PermissionManagementControllerBase, IPermissionAppService
    {
        private readonly IPermissionAppService _permissionAppService;

        public PermissionController(IPermissionAppService permissionAppService)
        {
            _permissionAppService = permissionAppService;
        }

        [HttpGet]
        public Task<GetPermissionListResultDto> GetAsync(string providerName, string providerKey)
        {
            return _permissionAppService.GetAsync(providerName, providerKey);
        }

        [HttpPut]
        public Task UpdateAsync(string providerName, string providerKey, UpdatePermissionsDto input)
        {
            return _permissionAppService.UpdateAsync(providerName, providerKey, input);
        }
    }
}