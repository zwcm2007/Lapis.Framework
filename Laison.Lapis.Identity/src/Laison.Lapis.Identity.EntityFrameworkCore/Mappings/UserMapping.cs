using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Laison.Lapis.Identity.Domain.Entities;
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
            builder.ToTable("Users");
            builder.ConfigureByConvention();
            // primary key
            builder.HasKey(o => o.Id);
            // object relations
            //builder.HasMany(o => o.OrderLines).WithOne(ol => ol.Order).HasForeignKey(ol => ol.OrderId).IsRequired();
            //
            builder.OwnsOne(o => o.Address);
        }
    }
}