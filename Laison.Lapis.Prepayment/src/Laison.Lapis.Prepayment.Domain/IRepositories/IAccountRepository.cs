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
    public interface ICustomerRepository : IBasicRepository<Customer, Guid>
    {
        Task OpenAccountAsync();

        //Task<List<TradeRecordBase>> GetOrdersAsync(Guid customerId);
    }
}