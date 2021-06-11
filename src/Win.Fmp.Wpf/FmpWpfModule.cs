using Microsoft.Extensions.DependencyInjection;
using Polly;
using System;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Win.Fmp.Wpf
{
    [DependsOn(
        typeof(FmpHttpApiClientModule),
        typeof(FmpApplicationContractsModule),
        typeof(AbpAutofacModule),
          typeof(AbpHttpClientIdentityModelModule)
    )]
    public class FmpWpfModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
           // context.Services.AddSingleton<MainWindow>();

            PreConfigure<AbpHttpClientBuilderOptions>(options =>
            {
                options.ProxyClientBuildActions.Add((remoteServiceName, clientBuilder) =>
                {
                    clientBuilder.AddTransientHttpErrorPolicy(
                        policyBuilder => policyBuilder.WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(Math.Pow(2, i)))
                    );
                });
            });

        }
  
    }
}