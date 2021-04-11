using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.MeterManagement.EntityFrameworkCore
{
    public class MeterManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public MeterManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}