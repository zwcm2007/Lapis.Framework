﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Laison.Lapis.SettingManagement.Domain.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.SettingManagement.EntityFrameworkCore
{
    /// <summary>
    /// OrderLine Mapping to db
    /// </summary>
    public class OrderLineMapping : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.ToTable("OrderLines");
            builder.ConfigureByConvention();
            // Primary Key
            builder.HasKey(ol => new { ol.OrderId, ol.ProductId });
        }
    }
}