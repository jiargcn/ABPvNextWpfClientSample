using System.Threading.Tasks;

namespace Win.Fmp.Data
{
    public interface IFmpDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
