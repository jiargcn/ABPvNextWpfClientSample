using Volo.Abp.Settings;

namespace Win.Fmp.Settings
{
    public class FmpSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FmpSettings.MySetting1));
        }
    }
}
