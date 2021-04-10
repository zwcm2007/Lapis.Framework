using System;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 充值交易记录
    /// </summary>
    public class RechargeTradeDetail : TradeDetailBase
    {
        protected RechargeTradeDetail()
        {
        }

        public RechargeTradeDetail(Guid id, Guid customerId, Guid operatorId, string invoiceNo)
            : base(id, customerId, operatorId, invoiceNo)
        {
        }
    }
}