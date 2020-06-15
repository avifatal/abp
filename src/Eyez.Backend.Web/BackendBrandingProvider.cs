using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Eyez.Backend.Web
{
    [Dependency(ReplaceServices = true)]
    public class BackendBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Backend";
    }
}
