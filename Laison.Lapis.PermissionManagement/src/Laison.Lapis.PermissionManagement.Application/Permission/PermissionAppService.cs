using JetBrains.Annotations;
using Laison.Lapis.PermissionManagement.Application.Contracts;
using Laison.Lapis.PermissionManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.PermissionManagement.Application
{
    /// <summary>
    /// 权限应用服务
    /// </summary>
    public class PermissionAppService : PermissionManagementAppServiceBase, IPermissionAppService
    {
        protected IPermissionManager PermissionManager { get; }
        protected IPermissionDefinitionManager PermissionDefinitionManager { get; }

        public PermissionAppService(IPermissionManager permissionManager,
            IPermissionDefinitionManager permissionDefinitionManager)
        {
            PermissionManager = permissionManager;
            PermissionDefinitionManager = permissionDefinitionManager;
        }

        /// <summary>
        /// 获取权限
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="providerKey"></param>
        /// <returns></returns>
        public async Task<GetPermissionListResultDto> GetAsync([NotNull] string providerName, [NotNull] string providerKey)
        {
            var result = new GetPermissionListResultDto
            {
                EntityDisplayName = providerKey,
                Groups = new List<PermissionGroupDto>()
            };

            var multiTenancySide = CurrentTenant.GetMultiTenancySide();

            foreach (var group in PermissionDefinitionManager.GetGroups())
            {
                var groupDto = new PermissionGroupDto
                {
                    Name = group.Name,
                    DisplayName = group.DisplayName.Localize(StringLocalizerFactory),
                    Permissions = new List<PermissionGrantInfoDto>()
                };

                foreach (var permission in group.GetPermissionsWithChildren())
                {
                    if (!permission.IsEnabled)
                    {
                        continue;
                    }

                    if (permission.Providers.Any() && !permission.Providers.Contains(providerName))
                    {
                        continue;
                    }

                    if (!permission.MultiTenancySide.HasFlag(multiTenancySide))
                    {
                        continue;
                    }

                    var grantInfoDto = new PermissionGrantInfoDto
                    {
                        Name = permission.Name,
                        DisplayName = permission.DisplayName.Localize(StringLocalizerFactory),
                        ParentName = permission.Parent?.Name,
                        AllowedProviders = permission.Providers,
                        //GrantedProviders = new List<ProviderInfoDto>()
                    };

                    var grantInfo = await PermissionManager.GetAsync(permission.Name, providerName, providerKey);

                    grantInfoDto.IsGranted = grantInfo.IsGranted;

                    groupDto.Permissions.Add(grantInfoDto);
                }

                if (groupDto.Permissions.Any())
                {
                    result.Groups.Add(groupDto);
                }
            }

            return result;
        }

        public Task UpdateAsync([NotNull] string providerName, [NotNull] string providerKey, UpdatePermissionsDto input)
        {
            throw new NotImplementedException();
        }
    }
}