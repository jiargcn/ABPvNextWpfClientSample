using Volo.Abp.Modularity;

namespace Win.Fmp
{
    [DependsOn(
        typeof(FmpApplicationModule),
        typeof(FmpDomainTestModule)
        )]
    public class FmpApplicationTestModule : AbpModule
    {

    }
}