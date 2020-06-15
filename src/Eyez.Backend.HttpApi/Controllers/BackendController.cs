using Eyez.Backend.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Eyez.Backend.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BackendController : AbpController
    {
        protected BackendController()
        {
            LocalizationResource = typeof(BackendResource);
        }
    }
}