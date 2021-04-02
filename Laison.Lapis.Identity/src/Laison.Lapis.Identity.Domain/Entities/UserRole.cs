using System;
using Volo.Abp.Domain.Entities;

namespace Laison.Lapis.Identity.Domain.Entities
{
    /// <summary>
    /// �û�/��ɫ����
    /// </summary>
    public class UserRole : Entity //, IMultiTenant
    {
        //public virtual Guid? TenantId { get; protected set; }

        public virtual Guid UserId { get; protected set; }

        public virtual Guid RoleId { get; protected set; }

        protected UserRole()
        {
        }

        protected internal UserRole(Guid userId, Guid roleId, Guid? tenantId)
        {
            UserId = userId;
            RoleId = roleId;
            //TenantId = tenantId;
        }

        public override object[] GetKeys()
        {
            return new object[] { UserId, RoleId };
        }
    }
}