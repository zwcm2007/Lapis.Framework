using Laison.Lapis.Prepayment.Domain.ValueObjects;
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
        public MoneyAmount Debt { get; protected set; }

        /// <summary>
        /// 制卡
        /// </summary>
        /// </summary>
        public bool MakeCard { get; protected set; }

        /// <summary>
        /// 开户时间
        /// </summary>
        public DateTime CreationTime { get; protected set; }

        protected Account()
        {
        }

        public Account(Guid id, string no, MoneyAmount debt, bool makeCard = false)
        {
            Id = id;
            No = no;
            Debt = debt;
            MakeCard = makeCard;
        }
    }
}