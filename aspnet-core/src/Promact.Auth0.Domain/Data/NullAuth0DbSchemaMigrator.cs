using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Promact.Auth0.Data;

/* This is used if database provider does't define
 * IAuth0DbSchemaMigrator implementation.
 */
public class NullAuth0DbSchemaMigrator : IAuth0DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
