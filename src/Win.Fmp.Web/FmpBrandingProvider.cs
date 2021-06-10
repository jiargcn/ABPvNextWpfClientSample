using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Win.Fmp.Web
{
    [Dependency(ReplaceServices = true)]
    public class FmpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Fmp";
    }
}
