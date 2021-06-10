using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Win.Fmp.EntityFrameworkCore;

namespace Win.Fmp.Wpf
{
    [DependsOn(
        typeof(FmpHttpApiModule),
        typeof(FmpApplicationModule),
        typeof(FmpEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAutofacModule)
    )]
    public class FmpWpfModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindow>();
        }
    }
}