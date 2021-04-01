using Laison.Lapis.Account.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    [ConnectionStringName(AccountDbProperties.ConnectionStringName)]
    public class AccountDbContext : AbpDbContext<AccountDbContext>, IAccountDbContext
    {
        // Add DbSet for each Aggregate Root
        //public DbSet<Order> Orders { get; set; }  // Todo: get or set ?

        public AccountDbContext(DbContextOptions<AccountDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAccount();
        }
    }
}