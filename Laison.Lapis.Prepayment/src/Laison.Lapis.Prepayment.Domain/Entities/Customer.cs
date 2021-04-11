using Laison.Lapis.Prepayment.Domain.ValueObjects;
using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Laison.Lapis.Prepayment.Domain.Entities
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer : ValueObject
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
        public string Telephone { get; protected set; }

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

        #region 构造函数

        internal Customer()
           : this(null, null, null, null)
        {
        }

        public Customer(string name, string email, string identityNo, string telephone)
        {
            Name = name;
            Email = email;
            IdentityNo = identityNo;
            Telephone = telephone;
            Address = new Address();
        }

        #endregion 构造函数

        /// <summary>
        /// 设置客户信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="identityNo"></param>
        /// <param name="town"></param>
        /// <param name="village"></param>
        /// <param name="address"></param>
        public void SetCustomer(string name, string identityNo, string telephone, string email)
        {
            Name = name;
            Email = email;
            IdentityNo = identityNo;
            Telephone = telephone;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return IdentityNo;
            yield return Telephone;
            yield return Email;
            yield return Address;
        }
    }
}