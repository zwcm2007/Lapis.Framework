using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Demo.Domain;
using Laison.Lapis.Demo.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Demo.EntityFrameworkCore
{
    [ConnectionStringName(DemoDbProperties.ConnectionStringName)]
    public class DemoDbContext : AbpDbContext<DemoDbContext>, IDemoDbContext
    {
        // Add DbSet for each Aggregate Root
        public DbSet<Order> Orders { get; set; }  // Todo: get or set ?

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDemo();
        }
    }
}