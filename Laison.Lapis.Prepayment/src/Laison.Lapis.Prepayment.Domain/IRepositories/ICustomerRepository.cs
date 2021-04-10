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
    public interface IAccountRepository : IBasicRepository<Customer, Guid>
    {
        //Task<T GetOrderAsync(Guid id);
        //Task<T GetOrderAsync(Guid id);
        //Task<T GetOrderAsync(Guid id);

        //Task<List<TradeRecordBase>> GetOrdersAsync(Guid customerId);
    }
}