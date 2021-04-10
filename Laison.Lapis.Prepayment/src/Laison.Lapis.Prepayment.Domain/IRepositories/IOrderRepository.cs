using Laison.Lapis.Prepayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Prepayment.Domain.IRepositories
{
    /// <summary>
    /// An interface for order repository
    /// </summary>
    public interface IOrderRepository : IBasicRepository<TradeRecordBase, Guid>
    {

        Task<TradeRecordBase> GetOrderAsync(Guid id);

        Task<List<TradeRecordBase>> GetOrdersAsync(Guid customerId);
    }
}