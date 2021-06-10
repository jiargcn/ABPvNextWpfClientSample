using Win.Fmp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Win.Fmp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FmpEntityFrameworkCoreDbMigrationsModule),
        typeof(FmpApplicationContractsModule)
        )]
    public class FmpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
