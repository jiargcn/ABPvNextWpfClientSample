using Win.Fmp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Win.Fmp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FmpController : AbpController
    {
        protected FmpController()
        {
            LocalizationResource = typeof(FmpResource);
        }
    }
}