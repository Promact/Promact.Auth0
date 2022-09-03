using System.Threading.Tasks;

namespace Promact.Auth0.Data;

public interface IAuth0DbSchemaMigrator
{
    Task MigrateAsync();
}
