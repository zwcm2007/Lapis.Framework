using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    public class PermissionManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<PermissionManagementHttpApiHostMigrationsDbContext>
    {
        public PermissionManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connStr = configuration.GetConnectionString("PermissionManagement");
            var builder = new DbContextOptionsBuilder<PermissionManagementHttpApiHostMigrationsDbContext>()
                .UseMySql(connStr, ServerVersion.AutoDetect(connStr));

            return new PermissionManagementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}