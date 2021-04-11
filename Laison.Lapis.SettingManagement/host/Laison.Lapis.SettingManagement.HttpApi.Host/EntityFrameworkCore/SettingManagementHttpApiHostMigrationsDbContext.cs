using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.SettingManagement.EntityFrameworkCore
{
    public class SettingManagementHttpApiHostMigrationsDbContext : AbpDbContext<SettingManagementHttpApiHostMigrationsDbContext>
    {
        public SettingManagementHttpApiHostMigrationsDbContext(DbContextOptions<SettingManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureSettingManagement();
        }
    }
}
