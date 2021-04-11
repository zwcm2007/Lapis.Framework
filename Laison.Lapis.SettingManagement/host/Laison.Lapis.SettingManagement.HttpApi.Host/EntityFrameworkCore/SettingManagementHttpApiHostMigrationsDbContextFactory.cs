using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Laison.Lapis.SettingManagement.EntityFrameworkCore
{
    public class SettingManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<SettingManagementHttpApiHostMigrationsDbContext>
    {
        public SettingManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connStr = configuration.GetConnectionString("SettingManagement");
            var builder = new DbContextOptionsBuilder<SettingManagementHttpApiHostMigrationsDbContext>()
                .UseMySql(connStr, ServerVersion.AutoDetect(connStr));

            return new SettingManagementHttpApiHostMigrationsDbContext(builder.Options);
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