using Eyez.Backend.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Eyez.Backend.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BackendEntityFrameworkCoreDbMigrationsModule),
        typeof(BackendApplicationContractsModule)
        )]
    public class BackendDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
