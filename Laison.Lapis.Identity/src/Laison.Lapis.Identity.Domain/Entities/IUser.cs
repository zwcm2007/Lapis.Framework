using JetBrains.Annotations;
using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// �û��ӿ�
    /// </summary>
    public interface IUser : IAggregateRoot<Guid>, IHasCreationTime , IMultiTenant
    {
        /// <summary>
        /// �û���
        /// </summary>
        string UserName { get; }

        /// <summary>
        /// �����ʼ�
        /// </summary>
        [CanBeNull]
        string Email { get; }

        /// <summary>
        /// ����
        /// </summary>
        [CanBeNull]
        string Name { get; }

        /// <summary>
        /// �绰����
        /// </summary>
        [CanBeNull]
        string PhoneNumber { get; }

        //[CanBeNull]
        //string Surname { get; }

        //bool EmailConfirmed { get; }

        //bool PhoneNumberConfirmed { get; }
    }
}