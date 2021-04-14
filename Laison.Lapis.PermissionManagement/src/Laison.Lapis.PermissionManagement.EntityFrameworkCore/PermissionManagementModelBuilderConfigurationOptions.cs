using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.PermissionManagement.EntityFrameworkCore
{
    public class PermissionManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public PermissionManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}