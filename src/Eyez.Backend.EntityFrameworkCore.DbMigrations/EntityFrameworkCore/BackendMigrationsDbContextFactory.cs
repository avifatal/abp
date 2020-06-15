using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Eyez.Backend.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BackendMigrationsDbContextFactory : IDesignTimeDbContextFactory<BackendMigrationsDbContext>
    {
        public BackendMigrationsDbContext CreateDbContext(string[] args)
        {
            BackendEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BackendMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BackendMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
