using System.ComponentModel.DataAnnotations;

namespace Laison.Lapis.Prepayment.Application.Contracts
{
    /// <summary>
    /// 开户输入
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
        [Required]
        public double Debt { get; set; }

        /// <summary>
        /// 是否制卡
        /// </summary>
        [Required]
        public bool MakeCard { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 表号
        /// </summary>
        [Required]
        public CustomerDto Customer { get; set; }
    }

    /// <summary>
    /// 客户Dto
    /// </summary>
    public class CustomerDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        /// </summary>
        public string IdentityNo { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        /// </summary>
        public AddressDto Address { get; set; }
    }

    /// <summary>
    /// 地址Dto
    /// </summary>
    public class AddressDto
    {
        public string Province { get; set; }

        public string City { get; set; }

        public string Town { get; set; }

        public string Village { get; set; }
    }
}