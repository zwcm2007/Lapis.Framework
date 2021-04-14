using System;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role : AggregateRoot<Guid>, IRole
    {
        /// <summary>
        /// 名称
        /// </summary>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; protected set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        public Guid? TenantId { get; protected set; }

        protected Role()
        {
        }

        public Role(Guid id, string name, Guid? tenantId = null)
        {
            Id = id;
            Name = name;
            TenantId = tenantId;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Name = {Name}";
        }
    }
}