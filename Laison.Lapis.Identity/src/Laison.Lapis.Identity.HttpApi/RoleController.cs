using Laison.Lapis.Identity.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Laison.Lapis.Identity.HttpApi
{
    //[RemoteService(Name = IdentityRemoteServiceConsts.RemoteServiceName)]
    //[Area("identity")]
    //[ControllerName("Role")]
    [Route("api/identity/roles")]
    public class RoleController : AbpController, IRoleAppService
    {
        private readonly IRoleAppService _roleAppService;

        public RoleController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        [HttpGet]
        [Route("all")]
        public virtual Task<ListResultDto<RoleDto>> GetAllListAsync()
        {
            return _roleAppService.GetAllListAsync();
        }
    }
}