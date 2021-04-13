using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 用户/角色实体映射
    /// </summary>
    public class UserRoleMapping : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("user_role");
            builder.ConfigureByConvention();
            // 主键
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });
        }
    }
}