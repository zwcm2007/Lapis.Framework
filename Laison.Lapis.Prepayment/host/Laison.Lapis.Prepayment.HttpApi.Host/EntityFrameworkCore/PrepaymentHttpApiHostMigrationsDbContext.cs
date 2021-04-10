using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    public class PrepaymentHttpApiHostMigrationsDbContext : AbpDbContext<PrepaymentHttpApiHostMigrationsDbContext>
    {
        public PrepaymentHttpApiHostMigrationsDbContext(DbContextOptions<PrepaymentHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePrepayment();
        }
    }
}
