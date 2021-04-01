using Laison.Lapis.Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Identity.Domain.IRepositories
{
    /// <summary>
    /// An interface for user repository
    /// </summary>
    public interface IUserRepository : IBasicRepository<User, Guid>
    {
        Task<User> FindByUserNameAsync(string userName, CancellationToken cancellationToken = default);

        Task<List<User>> SearchAsync(string sorting = null, int maxResultCount = int.MaxValue,
            int skipCount = 0,
            string filter = null,
            CancellationToken cancellationToken = default);

        Task<long> GetCountAsync(string filter = null,
            CancellationToken cancellationToken = default);
    }
}