using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Volo.Abp;

namespace Laison.Lapis.SettingManagement.EntityFrameworkCore
{
    public static class SettingManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureSettingManagement(
            this ModelBuilder builder,
            Action<SettingManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new SettingManagementModelBuilderConfigurationOptions(
            //    SettingManagementDbProperties.DbTablePrefix,
            //    SettingManagementDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}