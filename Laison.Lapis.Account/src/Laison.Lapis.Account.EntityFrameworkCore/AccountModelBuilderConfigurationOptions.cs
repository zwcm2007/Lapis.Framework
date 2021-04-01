using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.Account.EntityFrameworkCore
{
    public class AccountModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AccountModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}