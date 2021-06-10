using Win.Fmp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Win.Fmp
{
    [DependsOn(
        typeof(FmpEntityFrameworkCoreTestModule)
        )]
    public class FmpDomainTestModule : AbpModule
    {

    }
}