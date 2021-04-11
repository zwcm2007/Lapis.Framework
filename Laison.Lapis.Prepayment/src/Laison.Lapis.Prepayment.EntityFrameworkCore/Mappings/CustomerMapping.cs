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
            // object relations
            builder.HasOne(c => c.Account).WithOne().HasForeignKey<Customer>(c => c.AccountId).IsRequired();
            //
            builder.OwnsOne(o => o.Address);
        }
    }
}