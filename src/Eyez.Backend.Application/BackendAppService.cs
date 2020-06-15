using System;
using System.Collections.Generic;
using System.Text;
using Eyez.Backend.Localization;
using Volo.Abp.Application.Services;

namespace Eyez.Backend
{
    /* Inherit your application services from this class.
     */
    public abstract class BackendAppService : ApplicationService
    {
        protected BackendAppService()
        {
            LocalizationResource = typeof(BackendResource);
        }
    }
}
