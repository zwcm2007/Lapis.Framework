using JetBrains.Annotations;
using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Identity.Domain.Entities
{
    public interface IUser : IAggregateRoot<Guid>, IHasCreationTime //, IMultiTenant
    {
        string UserName { get; } // 用户名

        [CanBeNull]
        string Email { get; }

        [CanBeNull]
        string Name { get; }  //姓名

        [CanBeNull]
        string PhoneNumber { get; }

        //[CanBeNull]
        //string Surname { get; }

        //bool EmailConfirmed { get; }

        //bool PhoneNumberConfirmed { get; }
    }
}