using System;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 购水交易记录
    /// </summary>
    public class PurchaseTradeDetail : TradeDetailBase
    {
        protected PurchaseTradeDetail()
        {
        }

        public PurchaseTradeDetail(Guid id, Guid customerId, Guid operatorId, string invoiceNo)
            : base(id, customerId, operatorId, invoiceNo)
        {
        }
    }
}