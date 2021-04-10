using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer : AggregateRoot<Guid>, IHasCreationTime
    {
        /// <summary>
        /// 户号
        /// </summary>
        /// </summary>
        public string No { get; protected set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        /// </summary>
        public string IdentityNo { get; protected set; }

        /// <summary>
        /// 电话
        /// </summary>
        /// </summary>
        public string Telphone { get; protected set; }

        /// <summary>
        /// 地址
        /// </summary>
        /// </summary>
        public Address Address { get; protected set; }




        public DateTime CreationTime => throw new NotImplementedException();

        protected Customer()
        {
        }

        public Customer(Guid orderId, Guid productId, int count)
        {
        }

        /// <summary>
        /// change product count
        /// </summary>
        internal void ChangeCount(int count)
        {
            Count = count;
        }

        public override object[] GetKeys()
        {
            return new object[] { OrderId, ProductId };
        }
    }
}