using Laison.Lapis.Prepayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Prepayment.Domain.IRepositories
{
    /// <summary>
    /// An interface for customer repository
    /// </summary>
    public interface IAccountRepository : IBasicRepository<Account, Guid>
    {

    }
}