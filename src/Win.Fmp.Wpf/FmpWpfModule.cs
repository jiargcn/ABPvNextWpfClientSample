using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Win.Fmp.Wpf
{
    [DependsOn(
        typeof(FmpHttpApiClientModule),
        typeof(FmpApplicationContractsModule),
      
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