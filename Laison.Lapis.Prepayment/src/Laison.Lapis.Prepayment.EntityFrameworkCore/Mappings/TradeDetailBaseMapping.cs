using Laison.Lapis.Prepayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    /// <summary>
    /// 开户交易映射
    /// </summary>
    public class TradeDetailBaseMapping : IEntityTypeConfiguration<TradeDetailBase>
    {
        public virtual void Configure(EntityTypeBuilder<TradeDetailBase> builder)
        {
            builder.ConfigureByConvention();

            builder.Property("InvoiceNo").HasMaxLength(10);
        }
    }
}