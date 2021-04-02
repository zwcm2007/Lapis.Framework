using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role : AggregateRoot<Guid>, IHasCreationTime
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

        protected Role()
        {
        }

        internal Role(Guid id, string name)
        {
            Id = id;
            Name = name;

        }

        public override string ToString()
        {
            return $"{base.ToString()}, Name = {Name}";
        }
    }
}