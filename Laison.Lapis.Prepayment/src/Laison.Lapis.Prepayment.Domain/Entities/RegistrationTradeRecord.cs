using System;
using System.Collections.Generic;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 开户交易记录
    /// </summary>
    public class RegistrationTradeRecord : TradeRecordBase
    {
        protected RegistrationTradeRecord()
        {
        }

        public RegistrationTradeRecord(Guid id, Guid customerId,  Guid operatorId)
        {
            Id = id;
            OperatorId = operatorId;
            CustomerId = customerId;
        }
    }
}