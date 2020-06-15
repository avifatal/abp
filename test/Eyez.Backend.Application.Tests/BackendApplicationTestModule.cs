using Volo.Abp.Modularity;

namespace Eyez.Backend
{
    [DependsOn(
        typeof(BackendApplicationModule),
        typeof(BackendDomainTestModule)
        )]
    public class BackendApplicationTestModule : AbpModule
    {

    }
}