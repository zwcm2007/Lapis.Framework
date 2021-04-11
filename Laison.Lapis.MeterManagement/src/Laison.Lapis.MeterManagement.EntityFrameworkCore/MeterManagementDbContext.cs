using Microsoft.EntityFrameworkCore;
using Laison.Lapis.MeterManagement.Domain;
using Laison.Lapis.MeterManagement.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.MeterManagement.EntityFrameworkCore
{
    [ConnectionStringName(MeterManagementDbProperties.ConnectionStringName)]
    public class MeterManagementDbContext : AbpDbContext<MeterManagementDbContext>, IMeterManagementDbContext
    {
        // Add DbSet for each Aggregate Root
        public DbSet<Order> Orders { get; set; }  // Todo: get or set ?

        public MeterManagementDbContext(DbContextOptions<MeterManagementDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMeterManagement();
        }
    }
}