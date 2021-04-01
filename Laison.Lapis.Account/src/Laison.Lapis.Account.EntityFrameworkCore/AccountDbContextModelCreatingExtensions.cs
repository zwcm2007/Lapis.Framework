using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Volo.Abp;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    public static class AccountDbContextModelCreatingExtensions
    {
        public static void ConfigureAccount(
            this ModelBuilder builder,
            Action<AccountModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new AccountModelBuilderConfigurationOptions(
            //    AccountDbProperties.DbTablePrefix,
            //    AccountDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}