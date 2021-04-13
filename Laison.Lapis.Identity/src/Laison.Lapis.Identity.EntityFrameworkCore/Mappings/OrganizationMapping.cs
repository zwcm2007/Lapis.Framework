using Laison.Lapis.Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    /// <summary>
    /// 组织映射
    /// </summary>
    public class OrganizationMapping : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organizations");
            builder.ConfigureByConvention();
            // Primary Key
            builder.HasKey(r => r.Id);
        }
    }
}