using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 账户
    /// </summary>
    public class Account : AggregateRoot<Guid>, IHasCreationTime
    {
        /// <summary>
        /// 户号
        /// </summary>
        /// </summary>
        public string No { get; protected set; }

        /// <summary>
        /// 债务
        /// </summary>
        /// </summary>
        public double Debt { get; protected set; }

        /// <summary>
        /// 制卡
        /// </summary>
        /// </summary>
        public bool MakeCard { get; protected set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// </summary>
        public string Remark { get; protected set; }

        /// <summary>
        /// 开户时间
        /// </summary>
        public DateTime CreationTime { get; protected set; }

        /// <summary>
        /// 客户信息
        /// </summary>
        public Customer Customer { get; protected set; }

        #region 构造函数

        protected Account()
        {
        }

        public Account(Guid id, string no, double debt, bool makeCard, string remark)
        {
            Id = id;
            No = no;
            Debt = debt;
            MakeCard = makeCard;
            Remark = remark;
            Customer = new Customer();
        }

        #endregion 构造函数
    }
}