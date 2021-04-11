using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 开户交易记录
    /// </summary>
    public class RegisterTradeDetail : TradeDetailBase
    {
        /// <summary>
        /// 开户费
        /// </summary>
        public double RegisterCharge { get; protected set; }


        protected RegisterTradeDetail()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerId"></param>
        /// <param name="operatorId"></param>
        /// <param name="openCharge">开户费</param>
        public RegisterTradeDetail(Guid id, Guid customerId, Guid operatorId, double openCharge)
        {
            Id = id;
            OperatorId = operatorId;
            CustomerId = customerId;
            RegisterCharge = openCharge;
        }
    }
}