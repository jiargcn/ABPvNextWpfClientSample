using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Win.Fmp.EntityFrameworkCore
{
    [DependsOn(
        typeof(FmpEntityFrameworkCoreModule)
        )]
    public class FmpEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FmpMigrationsDbContext>();
        }
    }
}
