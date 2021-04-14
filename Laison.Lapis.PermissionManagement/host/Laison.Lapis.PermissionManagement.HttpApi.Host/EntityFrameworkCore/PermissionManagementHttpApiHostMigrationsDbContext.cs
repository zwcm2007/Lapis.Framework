using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    public class PermissionManagementHttpApiHostMigrationsDbContext : AbpDbContext<PermissionManagementHttpApiHostMigrationsDbContext>
    {
        public PermissionManagementHttpApiHostMigrationsDbContext(DbContextOptions<PermissionManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePermissionManagement();
        }
    }
}
