using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace Laison.Lapis.Identity
{
    /// <summary>
    /// 默认语言配置
    /// </summary>
    public class DefaultLangSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            var defaultLang = context.GetOrNull(LocalizationSettingNames.DefaultLanguage);
            if (defaultLang != null)
            {
                defaultLang.DefaultValue = "zh-Hans";  //默认设置中文
            }
        }
    }
}