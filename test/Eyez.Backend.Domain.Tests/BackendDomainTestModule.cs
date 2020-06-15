using Eyez.Backend.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Eyez.Backend
{
    [DependsOn(
        typeof(BackendEntityFrameworkCoreTestModule)
        )]
    public class BackendDomainTestModule : AbpModule
    {

    }
}