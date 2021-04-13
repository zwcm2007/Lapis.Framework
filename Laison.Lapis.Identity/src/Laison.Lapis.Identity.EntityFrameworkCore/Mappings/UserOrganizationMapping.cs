using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 用户/组织实体映射
    /// </summary>
    public class UserOrganizationMapping : IEntityTypeConfiguration<UserOrganization>
    {
        public void Configure(EntityTypeBuilder<UserOrganization> builder)
        {
            builder.ToTable("UserOrganization");
            builder.ConfigureByConvention();
            // 主键
            builder.HasKey(uo => new { uo.UserId, uo.OrganizationId });
        }
    }
}