using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Laison.Lapis.Identity.Domain;
using Laison.Lapis.Identity.Domain.Entities;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Identity.EntityFrameworkCore
{
    public static class IdentityDbContextModelCreatingExtensions
    {
        public static void ConfigureIdentity(
            this ModelBuilder builder,
            Action<IdentityModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new IdentityModelBuilderConfigurationOptions(
            //    IdentityDbProperties.DbTablePrefix,
            //    IdentityDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}