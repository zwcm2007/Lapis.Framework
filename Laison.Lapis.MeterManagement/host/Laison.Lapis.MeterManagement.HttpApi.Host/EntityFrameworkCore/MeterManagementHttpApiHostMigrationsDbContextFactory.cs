using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Laison.Lapis.MeterManagement.EntityFrameworkCore
{
    public class MeterManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MeterManagementHttpApiHostMigrationsDbContext>
    {
        public MeterManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connStr = configuration.GetConnectionString("MeterManagement");
            var builder = new DbContextOptionsBuilder<MeterManagementHttpApiHostMigrationsDbContext>()
                .UseMySql(connStr, ServerVersion.AutoDetect(connStr));

            return new MeterManagementHttpApiHostMigrationsDbContext(builder.Options);
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