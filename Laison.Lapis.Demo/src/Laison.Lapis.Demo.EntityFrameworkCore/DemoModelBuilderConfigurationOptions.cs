using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Demo.EntityFrameworkCore
{
    public class DemoModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DemoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}