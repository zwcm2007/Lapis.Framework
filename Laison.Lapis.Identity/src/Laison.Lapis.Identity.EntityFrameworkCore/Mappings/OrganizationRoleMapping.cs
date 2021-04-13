using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 组织/角色实体映射
    /// </summary>
    public class OrganizationRoleMapping : IEntityTypeConfiguration<OrganizationRole>
    {
        public void Configure(EntityTypeBuilder<OrganizationRole> builder)
        {
            builder.ToTable("OrganizationRoles");
            builder.ConfigureByConvention();
            // 主键
            builder.HasKey(or => new { or.OrganizationId, or.RoleId });
        }
    }
}