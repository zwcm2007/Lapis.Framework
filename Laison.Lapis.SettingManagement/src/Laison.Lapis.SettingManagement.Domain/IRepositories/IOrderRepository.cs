using Laison.Lapis.SettingManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.SettingManagement.Domain.IRepositories
{
    /// <summary>
    /// An interface for order repository
    /// </summary>
    public interface IOrderRepository : IBasicRepository<Order, Guid>
    {

        Task<Order> GetOrderAsync(Guid id);

        Task<List<Order>> GetOrdersAsync(Guid customerId);
    }
}