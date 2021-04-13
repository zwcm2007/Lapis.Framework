using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 用户/组织关联
    /// </summary>
    public class UserOrganization : Entity, IMultiTenant
    {
        public virtual Guid UserId { get; protected set; }

        public virtual Guid OrganizationId { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }

        protected UserOrganization()
        {
        }

        public UserOrganization(Guid userId, Guid orgId, Guid? tenantId)
        {
            UserId = userId;
            OrganizationId = orgId;
            TenantId = tenantId;
        }

        public override object[] GetKeys()
        {
            return new object[] { UserId, OrganizationId };
        }
    }
}