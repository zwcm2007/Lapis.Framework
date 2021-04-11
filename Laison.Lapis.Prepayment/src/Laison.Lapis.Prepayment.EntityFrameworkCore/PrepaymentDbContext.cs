﻿using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Prepayment.Domain;
using Laison.Lapis.Prepayment.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    [ConnectionStringName(PrepaymentDbProperties.ConnectionStringName)]
    public class PrepaymentDbContext : AbpDbContext<PrepaymentDbContext>, IPrepaymentDbContext
    {
        public DbSet<Customer> Customers { get; set; }  // Todo: get or set ?
        public DbSet<Account> Accounts { get; set; }  // Todo: get or set ?

        public PrepaymentDbContext(DbContextOptions<PrepaymentDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigurePrepayment();
        }
    }
}