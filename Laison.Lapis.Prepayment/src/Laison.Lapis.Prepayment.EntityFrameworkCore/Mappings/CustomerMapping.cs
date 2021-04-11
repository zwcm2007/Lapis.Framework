using Laison.Lapis.Prepayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    /// <summary>
    /// 客户映射
    /// </summary>
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.ConfigureByConvention();
            // primary key
            builder.HasKey(c => c.Id);
            // owned entity
            builder.OwnsOne(o => o.CustomerAddress, ca =>
            {
                ca.Property(p => p.Province).HasColumnName("AddressProvince");
                ca.Property(p => p.City).HasColumnName("AddressCity");
                ca.Property(p => p.Town).HasColumnName("AddressTown");
                ca.Property(p => p.Village).HasColumnName("AddressVillage");
            });
        }
    }
}