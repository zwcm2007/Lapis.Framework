using System;
using Volo.Abp.Application.Dtos;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    public class AccountDto : EntityDto<Guid>
    {
        /// <summary>
        /// 户号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 债务
        /// </summary>
        /// </summary>
        public double Debt { get; set; }

        /// <summary>
        /// 是否制卡
        /// </summary>
        public bool MakeCard { get; set; }

        /// <summary>
        /// 客户信息
        /// </summary>
        public CustomerDto Customer { get; set; }
    }
}