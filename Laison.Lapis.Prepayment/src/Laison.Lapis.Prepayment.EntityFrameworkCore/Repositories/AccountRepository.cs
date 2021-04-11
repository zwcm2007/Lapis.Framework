using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    /// <summary>
    /// 账户
    /// </summary>
    public class AccountRepository : EfCoreRepository<IPrepaymentDbContext, Account, Guid>, IAccountRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public AccountRepository(IDbContextProvider<IPrepaymentDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}