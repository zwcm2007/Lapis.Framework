using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Prepayment.Domain.Entities;
using Laison.Lapis.Prepayment.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    /// <summary>
    /// Order Repository
    /// </summary>
    public class CustomerRepository : EfCoreRepository<IPrepaymentDbContext, Customer, Guid>, ICustomerRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public CustomerRepository(IDbContextProvider<IPrepaymentDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        //public async Task<Trade> GetOrderAsync(Guid id)
        //{
        //    return await FindAsync(id, true);
        //}

        //public async Task<List<Trade>> GetOrdersAsync(Guid customerId)
        //{
        //    var query = await GetQueryableAsync();
        //    return await query.Where(o => o.CustomerId == customerId)
        //        .OrderByDescending(o => o.CreationTime)
        //        .ToListAsync();
        //}
    }
}