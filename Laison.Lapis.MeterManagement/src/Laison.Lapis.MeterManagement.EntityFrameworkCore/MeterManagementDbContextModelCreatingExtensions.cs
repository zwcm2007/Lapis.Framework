using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Volo.Abp;

namespace Laison.Lapis.MeterManagement.EntityFrameworkCore
{
    public static class MeterManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureMeterManagement(
            this ModelBuilder builder,
            Action<MeterManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new MeterManagementModelBuilderConfigurationOptions(
            //    MeterManagementDbProperties.DbTablePrefix,
            //    MeterManagementDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}