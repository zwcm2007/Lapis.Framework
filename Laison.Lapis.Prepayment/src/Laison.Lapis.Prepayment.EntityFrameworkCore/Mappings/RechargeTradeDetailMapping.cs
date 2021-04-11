using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Laison.Lapis.Prepayment.Domain.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    /// <summary>
    /// 充值交易映射
    /// </summary>
    public class RechargeTradeDetailMapping : IEntityTypeConfiguration<RechargeTradeDetail>
    {
        public void Configure(EntityTypeBuilder<RechargeTradeDetail> builder)
        {
            builder.ToTable("Recharge_Trade_Detail");
            builder.ConfigureByConvention();
            //

        }
    }
}