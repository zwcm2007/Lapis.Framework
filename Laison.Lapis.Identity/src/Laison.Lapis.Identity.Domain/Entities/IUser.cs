using JetBrains.Annotations;
using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 用户接口
    /// </summary>
    public interface IUser : IAggregateRoot<Guid>, IHasCreationTime , IMultiTenant
    {
        /// <summary>
        /// 用户名
        /// </summary>
        string UserName { get; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        [CanBeNull]
        string Email { get; }

        /// <summary>
        /// 姓名
        /// </summary>
        [CanBeNull]
        string Name { get; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [CanBeNull]
        string PhoneNumber { get; }

        //[CanBeNull]
        //string Surname { get; }

        //bool EmailConfirmed { get; }

        //bool PhoneNumberConfirmed { get; }
    }
}