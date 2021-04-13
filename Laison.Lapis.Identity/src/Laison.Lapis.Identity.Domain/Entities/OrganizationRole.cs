using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 组织/角色关联
    /// </summary>
    public class OrganizationRole : Entity, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }

        public virtual Guid RoleId { get; protected set; }

        public virtual Guid OrganizationId { get; protected set; }

        protected OrganizationRole()
        {
        }

        public OrganizationRole(Guid roleId, Guid orgId, Guid? tenantId = null)
        {
            RoleId = roleId;
            OrganizationId = orgId;
            TenantId = tenantId;
        }

        public override object[] GetKeys()
        {
            return new object[] { OrganizationId, RoleId };
        }
    }
}