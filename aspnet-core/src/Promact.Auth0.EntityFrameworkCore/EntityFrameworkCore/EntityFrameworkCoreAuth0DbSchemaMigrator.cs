using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Promact.Auth0.Data;
using Volo.Abp.DependencyInjection;

namespace Promact.Auth0.EntityFrameworkCore;

public class EntityFrameworkCoreAuth0DbSchemaMigrator
    : IAuth0DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAuth0DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Auth0DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Auth0DbContext>()
            .Database
            .MigrateAsync();
    }
}
