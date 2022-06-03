using Abp.Modules;
using Abp.Reflection.Extensions;
using Promact.Auth0.Localization;

namespace Promact.Auth0
{
    public class Auth0CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            Auth0LocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = Auth0Consts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Auth0CoreModule).GetAssembly());
        }
    }
}