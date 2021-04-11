using Microsoft.EntityFrameworkCore;
using Laison.Lapis.SettingManagement.Domain;
using Laison.Lapis.SettingManagement.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.SettingManagement.EntityFrameworkCore
{
    [ConnectionStringName(SettingManagementDbProperties.ConnectionStringName)]
    public class SettingManagementDbContext : AbpDbContext<SettingManagementDbContext>, ISettingManagementDbContext
    {
        // Add DbSet for each Aggregate Root
        public DbSet<Order> Orders { get; set; }  // Todo: get or set ?

        public SettingManagementDbContext(DbContextOptions<SettingManagementDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSettingManagement();
        }
    }
}