using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0024.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OSPlatformProvider"/> implementation of <see cref="IOSPlatformProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOSPlatformProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOSPlatformProvider, OSPlatformProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OSPlatformProvider"/> implementation of <see cref="IOSPlatformProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOSPlatformProvider> AddOSPlatformProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IOSPlatformProvider>(() => services.AddOSPlatformProvider());
            return serviceAction;
        }
    }
}
