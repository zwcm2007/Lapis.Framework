using JetBrains.Annotations;
using Laison.Lapis.PermissionManagement.Application.Contracts;
using Laison.Lapis.PermissionManagement.Domain;
using System;
using System.Threading.Tasks;
using Volo.Abp.Uow;

namespace Laison.Lapis.PermissionManagement.Application
{
    /// <summary>
    /// 权限应用服务
    /// </summary>
    public class PermissionAppService : PermissionManagementAppServiceBase, IPermissionAppService
    {
        private readonly IPermissionGrantRepository _permissionGrantRepository;

        public PermissionAppService(IPermissionGrantRepository orderRepository)
        {
            _permissionGrantRepository = orderRepository;
        }

        public Task UpdateAsync([NotNull] string providerName, [NotNull] string providerKey, UpdatePermissionsDto input)
        {
            throw new NotImplementedException();
        }
    }
}