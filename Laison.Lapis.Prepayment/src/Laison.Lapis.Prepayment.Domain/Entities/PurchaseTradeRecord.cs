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

        public PurchaseTradeRecord(Guid id, Guid customerId, Guid operatorId, string invoiceNo)
            : base(id, customerId, operatorId, invoiceNo)
        {
        }
    }
}