using System;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 购水交易记录
    /// </summary>
    public class PurchaseTradeRecord : TradeRecordBase
    {
        protected PurchaseTradeRecord()
        {
        }

        public PurchaseTradeRecord(Guid id, Guid customerId, Guid operatorId)
            : base()
        {
            Id = id;
            OperatorId = operatorId;
            CustomerId = customerId;
        }
    }
}