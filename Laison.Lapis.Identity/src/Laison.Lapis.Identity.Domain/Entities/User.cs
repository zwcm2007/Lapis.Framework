using Laison.Lapis.Identity.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : AggregateRoot<Guid>, IUser
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; protected set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; protected set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email { get; protected set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Sex? Sex { get; protected set; }

        /// <summary>
        /// 地址
        /// </summary>
        public Address Address { get; protected set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; protected set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; protected set; }

        /// <summary>
        /// 所属角色
        /// </summary>
        public virtual ICollection<UserRole> Roles { get; protected set; }

        protected User()
        {
        }

        public User(Guid id, string userName, string password, string name, string email, Sex? sex, string phoneNumber)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="currentPwd"></param>
        /// <param name="newPwd"></param>
        public void ChangePassword(string currentPwd, string newPwd)
        {
            if (currentPwd != Password)
            {
                throw new UserFriendlyException("原密码不正确", IdentityErrorCodes.CurrentPasswordIsError);
            }

            Password = newPwd;
        }
    }
}