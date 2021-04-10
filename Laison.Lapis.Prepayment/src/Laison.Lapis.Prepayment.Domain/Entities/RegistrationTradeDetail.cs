﻿using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 开户交易记录
    /// </summary>
    public class RegistrationTradeDetail : TradeDetailBase
    {
        /// <summary>
        /// 开户费
        /// </summary>
        public MoneyAmount OpenAccountCharge { get; protected set; }

        protected RegistrationTradeDetail()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerId"></param>
        /// <param name="operatorId"></param>
        /// <param name="openCharge">开户费</param>
        public RegistrationTradeDetail(Guid id, Guid customerId, Guid operatorId, MoneyAmount openCharge)
        {
            Id = id;
            OperatorId = operatorId;
            CustomerId = customerId;
            OpenAccountCharge = openCharge;
        }
    }
}