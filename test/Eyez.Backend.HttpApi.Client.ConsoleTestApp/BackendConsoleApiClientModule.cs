﻿using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Eyez.Backend.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(BackendHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BackendConsoleApiClientModule : AbpModule
    {
        
    }
}
