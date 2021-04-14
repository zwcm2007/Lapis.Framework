using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Volo.Abp;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    public static class PermissionManagementDbContextModelCreatingExtensions
    {
        public static void ConfigurePermissionManagement(
            this ModelBuilder builder,
            Action<PermissionManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new PermissionManagementModelBuilderConfigurationOptions(
            //    PermissionManagementDbProperties.DbTablePrefix,
            //    PermissionManagementDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}