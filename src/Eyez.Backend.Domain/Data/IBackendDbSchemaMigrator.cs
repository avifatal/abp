using System.Threading.Tasks;

namespace Eyez.Backend.Data
{
    public interface IBackendDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
