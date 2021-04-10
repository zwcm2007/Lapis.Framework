using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 开户交易记录
    /// </summary>
    public class RegistrationTradeRecord : TradeRecordBase
    {
        /// <summary>
        /// 开户费
        /// </summary>
        public MoneyAmount OpenAccountCharge { get; protected set; }

        protected RegistrationTradeRecord()
        {
        }

        public RegistrationTradeRecord(Guid id, Guid customerId, Guid operatorId)
        {
            Id = id;
            OperatorId = operatorId;
            CustomerId = customerId;
        }
    }
}