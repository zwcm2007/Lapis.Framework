using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// ��ɫ�ӿ�
    /// </summary>
    public interface IRole : IAggregateRoot<Guid>, IHasCreationTime, IMultiTenant
    {
        /// <summary>
        /// ��ɫ����
        /// </summary>
        string Name { get; }
    }
}