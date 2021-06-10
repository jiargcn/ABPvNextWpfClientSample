using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Win.Fmp.Data
{
    /* This is used if database provider does't define
     * IFmpDbSchemaMigrator implementation.
     */
    public class NullFmpDbSchemaMigrator : IFmpDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}