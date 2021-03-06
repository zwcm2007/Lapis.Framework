using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.PermissionManagement.Domain
{
    //TODO: To aggregate root?
    public class PermissionGrant : AggregateRoot<Guid>, IMultiTenant
    {
        [NotNull]
        public virtual string Name { get; protected set; }

        [NotNull]
        public virtual string ProviderName { get; protected set; }

        [CanBeNull]
        public virtual string ProviderKey { get; protected internal set; }

        public virtual Guid? TenantId { get; protected set; }

        protected PermissionGrant()
        {
        }

        public PermissionGrant(
            Guid id,
            [NotNull] string name,
            [NotNull] string providerName,
            [CanBeNull] string providerKey,
            Guid? tenantId = null)
        {
            Check.NotNull(name, nameof(name));

            Id = id;
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
            ProviderName = Check.NotNullOrWhiteSpace(providerName, nameof(providerName));
            ProviderKey = providerKey;
            TenantId = tenantId;
        }
    }
}