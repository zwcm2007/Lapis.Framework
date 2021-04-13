using Laison.Lapis.Identity.Domain.Entities;
using Laison.Lapis.Identity.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 用户映射
    /// </summary>
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.ConfigureByConvention();
            // 主键
            builder.HasKey(u => u.Id);
            // 关系
            builder.HasMany(u => u.Roles).WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            builder.HasMany(u => u.Organizations).WithOne().HasForeignKey(ur => ur.OrganizationId).IsRequired();
            // 属性
            builder.Property(u => u.TenantId).HasColumnName(nameof(IUser.TenantId));
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(UserConsts.MaxUserNameLength).HasColumnName(nameof(IUser.UserName));
            builder.Property(u => u.Email).IsRequired().HasMaxLength(UserConsts.MaxEmailLength).HasColumnName(nameof(IUser.Email));
            builder.Property(u => u.Name).HasMaxLength(UserConsts.MaxNameLength).HasColumnName(nameof(IUser.Name));
            builder.Property(u => u.PhoneNumber).HasMaxLength(UserConsts.MaxPhoneNumberLength).HasColumnName(nameof(IUser.PhoneNumber));
            // 从属
            builder.OwnsOne(o => o.Address);
        }
    }
}