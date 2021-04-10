using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer : AggregateRoot<Guid>
    {
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
        /// 电子邮件
        /// </summary>
        /// </summary>
        public string Email { get; protected set; }

        /// <summary>
        /// 地址
        /// </summary>
        /// </summary>
        public Address Address { get; protected set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// </summary>
        public string Remark { get; protected set; }

        /// <summary>
        /// 账户ID
        /// </summary>
        public Guid AccountId { get; protected set; }

        /// <summary>
        /// 账户
        /// </summary>
        public Account Account { get; protected set; }

        protected Customer()
        {
        }

        public Customer(Guid id, Guid accountId, string name, string email, string identityNo)
        {
            Id = id;
            AccountId = accountId;
            Name = name;
            Email = email;
            IdentityNo = identityNo;
        }

        public void Change(string name, string email, string identityNo)
        {
            Name = name;
        }
    }
}