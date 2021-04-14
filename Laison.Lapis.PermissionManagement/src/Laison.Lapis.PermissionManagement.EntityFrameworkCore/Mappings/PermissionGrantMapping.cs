using Laison.Lapis.PermissionManagement.Domain;
using Laison.Lapis.PermissionManagement.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    /// <summary>
    /// 权限映射
    /// </summary>
    public class PermissionGrantMapping : IEntityTypeConfiguration<PermissionGrant>
    {
        public void Configure(EntityTypeBuilder<PermissionGrant> builder)
        {
            builder.ToTable("PermissionGrants");
            builder.ConfigureByConvention();
            // primary key
            builder.HasKey(o => o.Id);
            // object relations
            builder.Property(x => x.Name).HasMaxLength(PermissionGrantConsts.MaxNameLength).IsRequired();
            builder.Property(x => x.ProviderName).HasMaxLength(PermissionGrantConsts.MaxProviderNameLength).IsRequired();
            builder.Property(x => x.ProviderKey).HasMaxLength(PermissionGrantConsts.MaxProviderKeyLength).IsRequired();
            builder.HasIndex(x => new { x.Name, x.ProviderName, x.ProviderKey });
        }
    }
}