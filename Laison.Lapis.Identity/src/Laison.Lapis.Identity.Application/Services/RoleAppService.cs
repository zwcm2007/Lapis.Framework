using Laison.Lapis.Identity.Application.Contracts;
using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Laison.Lapis.Identity.Application
{
    /// <summary>
    /// 角色应用服务
    /// </summary>
    [Authorize(IdentityPermissions.Roles.Default)]
    public class RoleAppService : IdentityAppServiceBase, IRoleAppService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleAppService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Authorize(IdentityPermissions.Roles.Create)]
        public virtual async Task<RoleDto> CreateAsync(RoleCreateDto input)
        {
            var role = new Role(
                GuidGenerator.Create(),
                input.Name,
                CurrentTenant.Id);

            // ToDo: 需要研究下
            //input.MapExtraPropertiesTo(role);

            //(await RoleManager.CreateAsync(role)).CheckErrors();
            await CurrentUnitOfWork.SaveChangesAsync();

            return ObjectMapper.Map<Role, RoleDto>(role);
        }

        public async Task<ListResultDto<RoleDto>> GetAllListAsync()
        {
            var roles = await _roleRepository.GetListAsync();

            var dtos = ObjectMapper.Map<List<Role>, List<RoleDto>>(roles);

            return new ListResultDto<RoleDto>(dtos);
        }
    }
}