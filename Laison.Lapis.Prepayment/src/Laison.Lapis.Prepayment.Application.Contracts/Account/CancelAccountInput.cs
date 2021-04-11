using System;
using Volo.Abp.Application.Dtos;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    /// <summary>
    /// 销户输入
    /// </summary>
    public class CancelAccountInput : EntityDto<Guid>
    {
        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }
    }
}