using Laison.Lapis.Identity.Application.Contracts;
using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Laison.Lapis.Identity.Application
{
    /// <summary>
    /// 角色应用服务
    /// </summary>
    public class RoleAppService : IdentityAppServiceBase, IRoleAppService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleAppService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<ListResultDto<RoleDto>> GetAllListAsync()
        {
            var roles = await _roleRepository.GetListAsync();

            var dtos = ObjectMapper.Map<List<Role>, List<RoleDto>>(roles);

            return new ListResultDto<RoleDto>(dtos);
        }
    }
}