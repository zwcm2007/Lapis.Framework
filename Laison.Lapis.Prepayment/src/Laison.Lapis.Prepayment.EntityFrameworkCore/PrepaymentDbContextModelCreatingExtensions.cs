using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Volo.Abp;

namespace Laison.Lapis.Prepayment.EntityFrameworkCore
{
    public static class PrepaymentDbContextModelCreatingExtensions
    {
        public static void ConfigurePrepayment(
            this ModelBuilder builder,
            Action<PrepaymentModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new PrepaymentModelBuilderConfigurationOptions(
            //    PrepaymentDbProperties.DbTablePrefix,
            //    PrepaymentDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}