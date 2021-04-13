using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 角色接口
    /// </summary>
    public interface IRole : IAggregateRoot<Guid>, IHasCreationTime, IMultiTenant
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        string Name { get; }
    }
}