using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;
using Polly;
using Volo.Abp;


namespace Win.Fmp.Wpf
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpHttpClientModule),
        // typeof(FmpHttpApiClientModule),
        typeof(FmpApplicationContractsModule),
        typeof(AbpHttpClientIdentityModelModule)
    )]
    public class FmpWpfModule: AbpModule
    {
       
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(FmpApplicationContractsModule).Assembly,
                remoteServiceConfigurationName: "Person"
            );
            context.Services.AddSingleton<MainWindow>();

        }

    }
}