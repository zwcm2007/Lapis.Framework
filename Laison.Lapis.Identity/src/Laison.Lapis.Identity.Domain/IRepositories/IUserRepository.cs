using Laison.Lapis.Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Identity.Domain.IRepositories
{
    /// <summary>
    /// An interface for user repository
    /// </summary>
    public interface IUserRepository : IBasicRepository<User, Guid>
    {

        //Task<User> GetOrderAsync(Guid id);

        //Task<List<User>> GetOrdersAsync(Guid customerId);
    }
}