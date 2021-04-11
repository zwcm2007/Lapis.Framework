using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Laison.Lapis.Prepayment.Domain.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    /// <summary>
    /// 开户交易映射
    /// </summary>
    public class RegisterTradeDetailMapping : IEntityTypeConfiguration<RegisterTradeDetail>
    {
        public void Configure(EntityTypeBuilder<RegisterTradeDetail> builder)
        {
            builder.ToTable("Register_Trade_Detail");
            builder.ConfigureByConvention();
            //

        }
    }
}