using Eyez.Backend.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Eyez.Backend.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BackendPageModel : AbpPageModel
    {
        protected BackendPageModel()
        {
            LocalizationResourceType = typeof(BackendResource);
        }
    }
}