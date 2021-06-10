using Win.Fmp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Win.Fmp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FmpPageModel : AbpPageModel
    {
        protected FmpPageModel()
        {
            LocalizationResourceType = typeof(FmpResource);
        }
    }
}