using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Laison.Lapis.Demo.EntityFrameworkCore
{
    public class DemoHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<DemoHttpApiHostMigrationsDbContext>
    {
        public DemoHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DemoHttpApiHostMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Demo"), ServerVersion.AutoDetect(configuration.GetConnectionString("Demo")));

            return new DemoHttpApiHostMigrationsDbContext(builder.Options);
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