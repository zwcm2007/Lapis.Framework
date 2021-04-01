using JetBrains.Annotations;
using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Identity.Domain.Entities
{
    public interface IUser : IAggregateRoot<Guid>, IHasCreationTime //, IMultiTenant
    {
        string UserName { get; } // �û���

        [CanBeNull]
        string Email { get; }

        [CanBeNull]
        string Name { get; }  //����

        [CanBeNull]
        string PhoneNumber { get; }

        //[CanBeNull]
        //string Surname { get; }

        //bool EmailConfirmed { get; }

        //bool PhoneNumberConfirmed { get; }
    }
}