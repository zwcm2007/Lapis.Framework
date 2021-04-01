using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 用户仓储
    /// </summary>
    public class UserRepository : EfCoreRepository<IIdentityDbContext, User, Guid>, IUserRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public UserRepository(IDbContextProvider<IIdentityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<User> FindByUserNameAsync(string userName, CancellationToken cancellationToken = default)
        {
            return await this.OrderBy(u => u.Id).FirstOrDefaultAsync(u => u.UserName == userName, GetCancellationToken(cancellationToken));
        }

        public async Task<List<User>> SearchAsync(
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            string filter = null,
            CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
               .WhereIf(
                    !filter.IsNullOrWhiteSpace(),
                    u =>
                        u.UserName.Contains(filter) ||
                        u.Email.Contains(filter) ||
                        u.Name.Contains(filter)
                )
                .OrderBy(sorting ?? nameof(IUser.UserName))
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public async Task<long> GetCountAsync(
            string filter = null,
            CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
                .WhereIf(!filter.IsNullOrWhiteSpace(), u =>
                      u.UserName.Contains(filter) ||
                      u.Email.Contains(filter) ||
                      u.Name.Contains(filter)
                )
                .LongCountAsync(GetCancellationToken(cancellationToken));
        }
    }
}