using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    public class AccountHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AccountHttpApiHostMigrationsDbContext>
    {
        public AccountHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connStr = configuration.GetConnectionString("Account");
            var builder = new DbContextOptionsBuilder<AccountHttpApiHostMigrationsDbContext>()
                .UseMySql(connStr, ServerVersion.AutoDetect(connStr));

            return new AccountHttpApiHostMigrationsDbContext(builder.Options);
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