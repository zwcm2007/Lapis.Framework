using JetBrains.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Laison.Lapis.PermissionManagement.Domain
{
    //TODO: Write extension methods for simple IsGranted check

    public interface IPermissionManager
    {
        Task<PermissionWithGrantedProviders> GetAsync(string permissionName, string providerName, string providerKey);

        Task<List<PermissionWithGrantedProviders>> GetAllAsync([NotNull] string providerName, [NotNull] string providerKey);

        Task SetAsync(string permissionName, string providerName, string providerKey, bool isGranted);

        Task<PermissionGrant> UpdateProviderKeyAsync(PermissionGrant permissionGrant, string providerKey);

        Task DeleteAsync(string providerName, string providerKey);
    }
}