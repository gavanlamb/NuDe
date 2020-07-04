using Microsoft.Extensions.DependencyInjection;
using NuDe.Services;
using NuDe.Services.Interfaces;

namespace NuDe.Extensions
{
    /// <summary>
    /// For services related functions for the NuDe project.
    /// </summary>
    public static class Services
    {
        /// <summary>
        /// Register all of NuDe's services to the applications ServiceCollection
        /// </summary>
        /// <param name="services">Collection of registered services.</param>
        public static void AddNuDe(this IServiceCollection services)
        {
            services.AddTransient<IDirectoryService, DirectoryService>();
        }
    }
}