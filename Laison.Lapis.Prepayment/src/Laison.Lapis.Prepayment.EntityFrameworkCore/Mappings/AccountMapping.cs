using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Laison.Lapis.Prepayment.Domain.Entities;
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
            //
            builder.HasOne(a => a.Customer).WithOne().HasForeignKey<Account>(c => c.Id).IsRequired();

        }
    }
}