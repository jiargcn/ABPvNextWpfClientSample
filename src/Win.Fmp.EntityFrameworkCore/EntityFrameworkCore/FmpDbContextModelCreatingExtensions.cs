using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Win.Fmp.Data;

namespace Win.Fmp.EntityFrameworkCore
{
    public static class FmpDbContextModelCreatingExtensions
    {
        public static void ConfigureFmp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Person>(b =>
            {
                b.ToTable("Persons");
                //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();

            });

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