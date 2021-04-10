﻿using System;
using System.Collections.Generic;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 交易记录
    /// </summary>
    public abstract class TradeRecordBase : AggregateRoot<Guid>, IHasCreationTime
    {
        /// <summary>
        /// customer id
        /// </summary>
        public Guid CustomerId { get; protected set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public Guid OperatorId { get; protected set; }

        /// <summary>
        /// 发票编号
        /// </summary>
        public string InvoiceNo { get; protected set; }

        /// <summary>
        /// create time
        /// </summary>
        public DateTime CreationTime { get; protected set; }


        protected TradeRecordBase()
        {
        }

        protected TradeRecordBase(Guid id, Guid customerId, Guid operatorId, string invoiceNo)
        {
            Id = id;
            CustomerId = customerId;
            InvoiceNo = invoiceNo;
        }
    }
}