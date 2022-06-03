using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Promact.Auth0.Configuration;
using Promact.Auth0.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Promact.Auth0.Web.Startup
{
    [DependsOn(
        typeof(Auth0ApplicationModule), 
        typeof(Auth0EntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class Auth0WebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Auth0WebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(Auth0Consts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<Auth0NavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(Auth0ApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Auth0WebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Auth0WebModule).Assembly);
        }
    }
}
