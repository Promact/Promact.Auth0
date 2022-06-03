using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Promact.Auth0
{
    [DependsOn(
        typeof(Auth0CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Auth0ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Auth0ApplicationModule).GetAssembly());
        }
    }
}