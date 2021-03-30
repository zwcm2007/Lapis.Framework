using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Demo.Domain;
using Laison.Lapis.Demo.Domain.Entities;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Demo.EntityFrameworkCore
{
    public static class DemoDbContextModelCreatingExtensions
    {
        public static void ConfigureDemo(
            this ModelBuilder builder,
            Action<DemoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new DemoModelBuilderConfigurationOptions(
            //    DemoDbProperties.DbTablePrefix,
            //    DemoDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}