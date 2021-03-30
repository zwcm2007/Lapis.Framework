﻿using Laison.Lapis.Demo.Application.Contracts;
using Laison.Lapis.Demo.Domain.Entities;
using Laison.Lapis.Demo.Domain.IRepositories;
using System;
using System.Threading.Tasks;
using Volo.Abp.Uow;

namespace Laison.Lapis.Demo.Application
{
    /// <summary>
    /// Order Application Service
    /// </summary>
    public class OrderAppService : DemoAppService, IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderAppService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [UnitOfWork]
        public async Task CreateOrderAsync(CreateOrderInput input)
        {
            var order = new Order(GuidGenerator.Create(), input.CustomerId);

            foreach (var item in input.OrderLines)
            {
                order.AddProduct(item.ProductId, item.Count);
            }
            await _orderRepository.InsertAsync(order);
        }

        public Task<OrderDto> GetOrderDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}