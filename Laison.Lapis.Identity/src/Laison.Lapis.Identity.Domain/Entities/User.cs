using Laison.Lapis.Identity.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : AggregateRoot<Guid>, IHasCreationTime
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; protected set; }

        /// <summary>
        /// 地址
        /// </summary>
        public Address Address { get; protected set; }

        /// <summary>
        /// create time
        /// </summary>
        public DateTime CreationTime { get; protected set; }

        ///// <summary>
        ///// sub-collecton of OrderLine
        ///// </summary>
        //public ICollection<Role> OrderLines { get; protected set; }

        protected User()
        {
        }

        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="oldPwd"></param>
        /// <param name="newPwd"></param>
        public void ChangePassword(string oldPwd, string newPwd)
        {
            if (oldPwd.ToMd5() != Password)
            {
                throw new UserFriendlyException("原密码不正确");
            }

            if (newPwd.ToMd5() == Password)
            {
                throw new UserFriendlyException("新密码和原密码相同");
            }

            Password = newPwd.ToMd5();
        }
    }
}