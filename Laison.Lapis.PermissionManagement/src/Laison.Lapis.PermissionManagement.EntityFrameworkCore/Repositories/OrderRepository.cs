using Microsoft.EntityFrameworkCore;
using Laison.Lapis.PermissionManagement.Domain.Entities;
using Laison.Lapis.PermissionManagement.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    /// <summary>
    /// Order Repository
    /// </summary>
    public class OrderRepository : EfCoreRepository<IPermissionManagementDbContext, Order, Guid>, IOrderRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="dbContextProvider"></param>
        public OrderRepository(IDbContextProvider<IPermissionManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<Order> GetOrderAsync(Guid id)
        {
            return await FindAsync(id, true);
        }

        public async Task<List<Order>> GetOrdersAsync(Guid customerId)
        {
            var query = await GetQueryableAsync();
            return await query.Where(o => o.CustomerId == customerId)
                .OrderByDescending(o => o.CreationTime)
                .ToListAsync();
        }
    }
}