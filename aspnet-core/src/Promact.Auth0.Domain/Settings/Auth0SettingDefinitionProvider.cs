using Volo.Abp.Settings;

namespace Promact.Auth0.Settings;

public class Auth0SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Auth0Settings.MySetting1));
    }
}
