using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;
using Polly;
using Volo.Abp;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;


namespace Win.Fmp.Wpf
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpHttpClientModule),
        // typeof(FmpHttpApiClientModule),
        typeof(FmpApplicationContractsModule),
        typeof(AbpAccountApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(AbpHttpClientIdentityModelModule)
    )]
    public class FmpWpfModule: AbpModule
    {
       
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(FmpApplicationContractsModule).Assembly
            );
            context.Services.AddHttpClientProxies(
                typeof(AbpAccountApplicationContractsModule).Assembly
            );
            context.Services.AddHttpClientProxies(
                typeof(AbpIdentityApplicationContractsModule).Assembly
            );
            context.Services.AddHttpClientProxies(
                typeof(AbpPermissionManagementApplicationContractsModule).Assembly
            );


            context.Services.AddSingleton<MainWindow>();

        }

    }
}