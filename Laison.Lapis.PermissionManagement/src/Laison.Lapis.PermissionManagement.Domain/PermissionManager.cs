using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.PermissionManagement.Domain
{
    public class PermissionManager : IPermissionManager, ISingletonDependency
    {
        protected IPermissionGrantRepository PermissionGrantRepository { get; }

        protected IPermissionDefinitionManager PermissionDefinitionManager { get; }

        protected IGuidGenerator GuidGenerator { get; }

        protected ICurrentTenant CurrentTenant { get; }

        //protected IReadOnlyList<IPermissionManagementProvider> ManagementProviders => _lazyProviders.Value;

        //protected PermissionManagementOptions Options { get; }

        //private readonly Lazy<List<IPermissionManagementProvider>> _lazyProviders;

        public PermissionManager(
            IPermissionDefinitionManager permissionDefinitionManager,
            IPermissionGrantRepository permissionGrantRepository,
            IServiceProvider serviceProvider,
            IGuidGenerator guidGenerator,
            //IOptions<PermissionManagementOptions> options,
            ICurrentTenant currentTenant)
        {
            GuidGenerator = guidGenerator;
            CurrentTenant = currentTenant;
            PermissionGrantRepository = permissionGrantRepository;
            PermissionDefinitionManager = permissionDefinitionManager;
            //Options = options.Value;

            //_lazyProviders = new Lazy<List<IPermissionManagementProvider>>(
            //    () => Options
            //        .ManagementProviders
            //        .Select(c => serviceProvider.GetRequiredService(c) as IPermissionManagementProvider)
            //        .ToList(),
            //    true
            //);
        }

        public virtual async Task<PermissionWithGrantedProviders> GetAsync(string permissionName, string providerName, string providerKey)
        {
            var permissionDefinition = PermissionDefinitionManager.Get(permissionName);

            return await GetInternalAsync(permissionDefinition, providerName, providerKey);
        }

        public virtual async Task<List<PermissionWithGrantedProviders>> GetAllAsync(string providerName, string providerKey)
        {
            var results = new List<PermissionWithGrantedProviders>();

            foreach (var permissionDefinition in PermissionDefinitionManager.GetPermissions())
            {
                results.Add(await GetInternalAsync(permissionDefinition, providerName, providerKey));
            }

            return results;
        }

        public virtual async Task SetAsync(string permissionName, string providerName, string providerKey, bool isGranted)
        {
            var permission = PermissionDefinitionManager.Get(permissionName);

            if (!permission.IsEnabled)
            {
                throw new BusinessException($"The permission named '{permission.Name}' is disabled!");
            }

            if (permission.Providers.Any() && !permission.Providers.Contains(providerName))
            {
                throw new BusinessException($"The permission named '{permission.Name}' has not compatible with the provider named '{providerName}'");
            }

            if (!permission.MultiTenancySide.HasFlag(CurrentTenant.GetMultiTenancySide()))
            {
                throw new BusinessException($"The permission named '{permission.Name}' has multitenancy side '{permission.MultiTenancySide}' which is not compatible with the current multitenancy side '{CurrentTenant.GetMultiTenancySide()}'");
            }

            var currentGrantInfo = await GetInternalAsync(permission, providerName, providerKey);
            if (currentGrantInfo.IsGranted == isGranted)
            {
                return;
            }

            await (isGranted ?
               GrantAsync(permissionName, providerName, providerKey) :
               RevokeAsync(permissionName, providerName, providerKey));
        }

        public virtual async Task<PermissionGrant> UpdateProviderKeyAsync(PermissionGrant permissionGrant, string providerKey)
        {
            permissionGrant.ProviderKey = providerKey;
            return await PermissionGrantRepository.UpdateAsync(permissionGrant);
        }

        public virtual async Task DeleteAsync(string providerName, string providerKey)
        {
            var permissionGrants = await PermissionGrantRepository.GetListAsync(providerName, providerKey);
            await PermissionGrantRepository.DeleteManyAsync(permissionGrants);
        }

        protected virtual async Task<PermissionWithGrantedProviders> GetInternalAsync(PermissionDefinition permission, string providerName, string providerKey)
        {
            var result = new PermissionWithGrantedProviders(permission.Name, false);

            if (!permission.IsEnabled)
            {
                return result;
            }

            if (!permission.MultiTenancySide.HasFlag(CurrentTenant.GetMultiTenancySide()))
            {
                return result;
            }

            if (permission.Providers.Any() && !permission.Providers.Contains(providerName))
            {
                return result;
            }

            var permissionGrant = await PermissionGrantRepository.FindAsync(permission.Name, providerName, providerKey);
            if (permissionGrant != null)
            {
                result.IsGranted = true;
                result.Providers.Add(new PermissionValueProviderInfo(providerName, providerKey));
            }

            return result;
        }



        protected virtual async Task GrantAsync(string name, string providerName, string providerKey)
        {
            var permissionGrant = await PermissionGrantRepository.FindAsync(name, providerName, providerKey);
            if (permissionGrant != null)
            {
                return;
            }

            await PermissionGrantRepository.InsertAsync(
                new PermissionGrant(
                    GuidGenerator.Create(),
                    name,
                    providerName,
                    providerKey,
                    CurrentTenant.Id
                )
            );
        }

        protected virtual async Task RevokeAsync(string name, string providerName, string providerKey)
        {
            var permissionGrant = await PermissionGrantRepository.FindAsync(name, providerName, providerKey);
            if (permissionGrant == null)
            {
                return;
            }

            await PermissionGrantRepository.DeleteAsync(permissionGrant);
        }
    }
}