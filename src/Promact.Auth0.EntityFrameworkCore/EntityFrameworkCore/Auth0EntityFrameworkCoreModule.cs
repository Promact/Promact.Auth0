using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Promact.Auth0.EntityFrameworkCore
{
    [DependsOn(
        typeof(Auth0CoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class Auth0EntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Auth0EntityFrameworkCoreModule).GetAssembly());
        }
    }
}