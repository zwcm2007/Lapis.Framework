using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.MeterManagement.EntityFrameworkCore
{
    public class MeterManagementHttpApiHostMigrationsDbContext : AbpDbContext<MeterManagementHttpApiHostMigrationsDbContext>
    {
        public MeterManagementHttpApiHostMigrationsDbContext(DbContextOptions<MeterManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureMeterManagement();
        }
    }
}
