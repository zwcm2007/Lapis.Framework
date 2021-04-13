using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 组织
    /// </summary>
    public class Organization : AggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }

        public virtual Guid? ParentId { get; internal set; }

        /// <summary>
        /// 组织代码
        /// </summary>
        public virtual string Code { get; internal set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// 组织创建的角色
        /// </summary>
        public virtual ICollection<OrganizationRole> Roles { get; protected set; }
    }
}