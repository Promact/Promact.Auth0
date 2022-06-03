using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Promact.Auth0.Web.Startup;
namespace Promact.Auth0.Web.Tests
{
    [DependsOn(
        typeof(Auth0WebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class Auth0WebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Auth0WebTestModule).GetAssembly());
        }
    }
}