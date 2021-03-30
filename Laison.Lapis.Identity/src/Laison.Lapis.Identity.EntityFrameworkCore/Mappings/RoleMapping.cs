using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 角色映射
    /// </summary>
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.ConfigureByConvention();
            // Primary Key
            builder.HasKey(r => r.Id);
        }
    }
}