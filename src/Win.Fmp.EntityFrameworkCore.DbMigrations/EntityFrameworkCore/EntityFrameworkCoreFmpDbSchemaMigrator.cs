using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Win.Fmp.Data;
using Volo.Abp.DependencyInjection;

namespace Win.Fmp.EntityFrameworkCore
{
    public class EntityFrameworkCoreFmpDbSchemaMigrator
        : IFmpDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFmpDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FmpMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FmpMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}