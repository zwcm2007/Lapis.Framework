using Laison.Lapis.Identity.Domain.Entities;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Identity.Domain.IRepositories
{
    /// <summary>
    /// An interface for user repository
    /// </summary>
    public interface IUserRepository : IBasicRepository<User, Guid>
    {
        Task<User> GetUserAsync(string userName);

        //Task<List<User>> GetOrdersAsync(Guid customerId);
    }
}