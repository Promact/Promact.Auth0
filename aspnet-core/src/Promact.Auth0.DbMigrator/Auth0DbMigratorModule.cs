using Promact.Auth0.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Promact.Auth0.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Auth0EntityFrameworkCoreModule),
    typeof(Auth0ApplicationContractsModule)
    )]
public class Auth0DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
