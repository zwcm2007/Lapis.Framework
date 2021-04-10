using Laison.Lapis.Prepayment.Domain.ValueObjects;
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

        public RegistrationTradeDetail(Guid id, Guid customerId, Guid operatorId, MoneyAmount charge)
        {
            Id = id;
            OperatorId = operatorId;
            CustomerId = customerId;
            OpenAccountCharge = charge;
        }
    }
}