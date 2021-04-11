using Laison.Lapis.Prepayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    /// <summary>
    /// 账户映射
    /// </summary>
    public class AccountMapping : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.ConfigureByConvention();
            // 从属属性
            builder.OwnsOne(a => a.Customer, c =>
            {
                c.ToTable("customer");

                c.OwnsOne(c => c.Address, address =>
                {
                    address.Property(p => p.Province).HasColumnName("AddressProvince");
                    address.Property(p => p.City).HasColumnName("AddressCity");
                    address.Property(p => p.Town).HasColumnName("AddressTown");
                    address.Property(p => p.Village).HasColumnName("AddressVillage");
                });
            });
            //builder.HasOne(a => a.Customer).WithOne().HasForeignKey<Account>(c => c.Id).IsRequired();
        }
    }
}