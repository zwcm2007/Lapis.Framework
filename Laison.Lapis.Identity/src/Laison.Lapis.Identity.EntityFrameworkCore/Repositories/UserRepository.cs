using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.IRepositories;
using System;
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
    }
}