using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Win.Fmp.EntityFrameworkCore
{
    public static class FmpDbContextModelCreatingExtensions
    {
        public static void ConfigureFmp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FmpConsts.DbTablePrefix + "YourEntities", FmpConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}