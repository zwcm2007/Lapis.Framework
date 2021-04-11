using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    /// <summary>
    /// create order dto
    /// </summary>
    public class CreateAccountInput
    {
        /// <summary>
        /// 表号
        /// </summary>
        [Required]
        public string MeterNo { get; set; }

        /// <summary>
        /// 债务
        /// </summary>
        /// </summary>
        public double Debt { get; protected set; }

        /// <summary>
        /// 表号
        /// </summary>
        [Required]
        public CustomerDto Customer { get; set; }
    }

    public class CustomerDto
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
    }
}