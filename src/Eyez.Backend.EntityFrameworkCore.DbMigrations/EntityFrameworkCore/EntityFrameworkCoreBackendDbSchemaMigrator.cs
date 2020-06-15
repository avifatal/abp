﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Eyez.Backend.Data;
using Volo.Abp.DependencyInjection;

namespace Eyez.Backend.EntityFrameworkCore
{
    public class EntityFrameworkCoreBackendDbSchemaMigrator
        : IBackendDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBackendDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BackendMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BackendMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}