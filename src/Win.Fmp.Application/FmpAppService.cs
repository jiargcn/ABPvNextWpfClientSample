using System.Collections.Generic;
using System.Text;
using Win.Fmp.Localization;
using Volo.Abp.Application.Services;

namespace Win.Fmp
{
    /* Inherit your application services from this class.
     */
    public abstract class FmpAppService : ApplicationService
    {

        protected FmpAppService()
        {
            
            LocalizationResource = typeof(FmpResource);
        }
    }
}
